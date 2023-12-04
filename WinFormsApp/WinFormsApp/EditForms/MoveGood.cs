using System.Data.SqlClient;
using WinFormsApp.Classes;

namespace WinFormsApp.Forms
{
    public partial class MoveGood : Form
    {
        DataBase dataBase = new();

        public DataGridView DataGridSG;
        public string StockName { get; set; }
        public int Amount { get; set; }

        public MoveGood(string stockName, int amount, DataGridView dataGridSG)
        {
            InitializeComponent();
            StockName = stockName;
            Amount = amount;
            DataGridSG = dataGridSG;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MoveGood_Load(object sender, EventArgs e)
        {
            label1.Text += $"{StockName} на склад:";
            string queryStocks = """
                SELECT S.Stock_Id AS Stock_Id,
                       S.Stock_Name AS Наименование,
                       S.Stock_Category AS Категория,
                       S.Stock_Address AS Адрес
                FROM Stocks S
                """;

            var stocks = Stocks.FillStocks(dataBase, queryStocks);
            if (stocks != null)
            {
                foreach (var stock in stocks)
                {
                    comboBoxStocks.Items.Add(stock.Name);
                }
                comboBoxStocks.Items.Remove(StockName);
            }
            numeric.Value = Amount;
            numeric.Maximum = Amount;
        }


        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (comboBoxStocks.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выбрали склад!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = DataGridSG.CurrentCell.RowIndex;
            string goodName = DataGridSG.Rows[index].Cells[1].Value.ToString();
            string stockToMoveName = comboBoxStocks.Text;
            int amount = (int)numeric.Value;

            string moveQuery = $"""
            DECLARE @goodAmount INT, @stockID INT, @goodID INT, @stockMoveID INT, @var INT;
            SET @goodID =
            (	SELECT G.Good_Id
            	FROM Stocks_Goods SG
            	JOIN Goods G ON G.Good_Id = SG.Good_Id
            	JOIN Stocks S ON S.Stock_Id = SG.Stock_Id
            	WHERE G.Good_Name = '{goodName}' AND Stock_Name = '{StockName}'
            );
            SET @stockID =
            (
            	SELECT S.Stock_Id
            	FROM Stocks_Goods SG
            	JOIN Goods G ON G.Good_Id = SG.Good_Id
            	JOIN Stocks S ON S.Stock_Id = SG.Stock_Id
            	WHERE G.Good_Name = '{goodName}' AND Stock_Name = '{StockName}'
            );
            SET @goodAmount = 
            (
            	SELECT SG.Good_Amount
            	FROM Stocks_Goods SG
            	WHERE SG.Good_Id = @goodID AND SG.Stock_Id = @stockID
            );
            SET @stockMoveID =
            (
            	SELECT S.Stock_Id
            	FROM Stocks S
            	WHERE S.Stock_Name = '{stockToMoveName}'
            );
            IF @goodAmount - {amount} = 0
            	BEGIN
            		DELETE FROM Stocks_Goods WHERE Good_Id = @goodID AND Stock_Id = @stockID
            	END
            ELSE
            	UPDATE Stocks_Goods
            	SET Good_Amount = Good_Amount - {amount}
            	WHERE Good_Id = @goodID AND Stock_Id = @stockID

            SELECT @var = count(SG.Good_Id)
            FROM Stocks_Goods SG
            WHERE SG.Good_Id = @goodID AND SG.Stock_Id = @stockMoveID

            IF @var = 0
            	BEGIN
            		INSERT INTO Stocks_Goods (Good_Id, Stock_Id, Good_Amount)
            		VALUES (@goodID, @stockMoveID, {amount})
            	END
            ELSE
            	UPDATE Stocks_Goods
            	SET Good_Amount = Good_Amount + @goodAmount
            	WHERE Good_Id = @goodID AND Stock_Id = @stockMoveID
            """;

            try
            {
                dataBase.OpenConnection();
                var command = new SqlCommand(moveQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
                dataBase.CloseConnection();

                MessageBox.Show("Товар был успешно перемещен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataGridSG.Rows.Clear();
                DataGridPerformer.FillColumnsStocksGoods(DataGridSG, dataBase, queryString);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При попытке перемещения товара произошла ошибка!", "Ошибка!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string queryString = """
                SELECT G.Good_Category AS Категория,
                	   G.Good_Name AS Товар,
                	   S.Stock_Name AS Склад,
                	   SG.Good_Amount AS Количество,
                	   SUM(Good_UnitPrice * Good_Amount) AS Стоимость
                FROM Stocks_Goods SG
                JOIN Goods G ON G.Good_Id = SG.Good_Id
                JOIN Stocks S ON S.Stock_Id = SG.Stock_Id
                GROUP BY G.Good_Category, G.Good_Name, S.Stock_Name, SG.Good_Amount
                """;
    }
}
