using System;
using System.Data.SqlClient;
using WinFormsApp.Classes;

namespace WinFormsApp.Forms
{
    public partial class UnloadGood : Form
    {
        DataBase dataBase = new();
        public DataGridView DataGridSG;
        public Label Label { get; set; }

        public UnloadGood(DataGridView dataGridSG, Label label)
        {
            InitializeComponent();
            DataGridSG = dataGridSG;
            Label = label;
        }

        private void buttonCalcel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UnloadGood_Load(object sender, EventArgs e)
        {
            int index = DataGridSG.CurrentRow.Index;
            label1.Text += $"{DataGridSG.Rows[index].Cells[2].Value}";
            numeric.Value = numeric.Maximum = Convert.ToDecimal(DataGridSG.Rows[index].Cells[3].Value);
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (numeric.Value == 0)
            {
                MessageBox.Show("Нельзя выбрать на отгрузку товара в количестве 0!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index = DataGridSG.CurrentRow.Index;
            string goodName = DataGridSG.Rows[index].Cells[1].Value.ToString();
            string stockName = DataGridSG.Rows[index].Cells[2].Value.ToString();
            int amount = Convert.ToInt32(numeric.Value);

            string unloadQuery = $"""
                DECLARE @goodAmount INT, @stockID INT, @goodID INT, @stockMoveID INT, @var INT;
                SET @goodID =
                (	SELECT G.Good_Id
                	FROM Stocks_Goods SG
                	JOIN Goods G ON G.Good_Id = SG.Good_Id
                	JOIN Stocks S ON S.Stock_Id = SG.Stock_Id
                	WHERE G.Good_Name = '{goodName}' AND Stock_Name = '{stockName}'
                )
                SET @stockID =
                (
                	SELECT S.Stock_Id
                	FROM Stocks_Goods SG
                	JOIN Goods G ON G.Good_Id = SG.Good_Id
                	JOIN Stocks S ON S.Stock_Id = SG.Stock_Id
                	WHERE G.Good_Name = '{goodName}' AND Stock_Name = '{stockName}'
                )
                SET @goodAmount = 
                (
                	SELECT SG.Good_Amount
                	FROM Stocks_Goods SG
                	WHERE SG.Good_Id = @goodID AND SG.Stock_Id = @stockID
                )
                IF @goodAmount - {amount} = 0
                	BEGIN
                		DELETE FROM Stocks_Goods WHERE Good_Id = @goodID AND Stock_Id = @stockID
                	END
                ELSE
                	UPDATE Stocks_Goods
                	SET Good_Amount = Good_Amount - {amount}
                	WHERE Good_Id = @goodID AND Stock_Id = @stockID
                """;

            try
            {
                dataBase.OpenConnection();
                var command = new SqlCommand(unloadQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
                dataBase.CloseConnection();

                MessageBox.Show("Товар был успешно отгружен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridSG.Rows.Clear();
                DataGridPerformer.FillColumnsStocksGoods(DataGridSG, dataBase, queryString);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("При попытке отгрузить товар произошла ошибка!", "Ошибка!",
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

        private void UnloadGood_FormClosed(object sender, FormClosedEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < DataGridSG.Rows.Count - 1; i++)
            {
                sum += (int)DataGridSG.Rows[i].Cells[4].Value;
            }
            Label.Text = $"Сумма товаров на складах: {sum} руб.";
        }
    }
}
