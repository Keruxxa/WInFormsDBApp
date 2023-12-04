using WinFormsApp.Classes;
using WinFormsApp.Forms;

namespace WinFormsApp
{
    public partial class StocksGoodsForm : Form
    {
        DataBase dataBase = new();
        public Form ParentForm { get; set; }
        public User User { get; set; }


        public StocksGoodsForm(Form parentForm, User user)
        {
            InitializeComponent();

            ParentForm = parentForm;
            User = user;

            CreateColumns(dataGridSG);
            DataGridPerformer.FillColumnsStocksGoods(dataGridSG, dataBase, queryString);
        }

        private void textBoxSearchGoods_TextChanged(object sender, EventArgs e)
        {
            dataGridSG.Rows.Clear();

            string querySearch = $"""
                WITH Temp AS
                (SELECT G.Good_Category AS Категория,
                	   G.Good_Name AS Товар,
                	   S.Stock_Name AS Склад,
                	   SG.Good_Amount AS Количество,
                	   SUM(Good_UnitPrice * Good_Amount) AS Стоимость
                FROM Stocks_Goods SG
                JOIN Goods G ON G.Good_Id = SG.Good_Id
                JOIN Stocks S ON S.Stock_Id = SG.Stock_Id
                GROUP BY G.Good_Category, G.Good_Name, S.Stock_Name, SG.Good_Amount)
                SELECT * FROM Temp
                WHERE CONCAT(Категория,
                             Товар,
                             Склад,
                             Количество)
                LIKE '%{textBoxSearch.Text.Trim()}%'
                """;

            DataGridPerformer.FillColumnsStocksGoods(dataGridSG, dataBase, querySearch);
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            int index = dataGridSG.CurrentCell.RowIndex;
            string stockName = dataGridSG.Rows[index].Cells[2].Value.ToString();
            int amount = (int)dataGridSG.Rows[index].Cells[3].Value;

            MoveGood moveGood = new(stockName, amount, dataGridSG);
            moveGood.Show();
        }

        private void unloadGood_Click(object sender, EventArgs e)
        {
            UnloadGood unloadGood = new(dataGridSG, labelSum);
            unloadGood.Show();
        }

        private async void btnPrintSG_Click(object sender, EventArgs e)
        {
            await Printer.PrintStocksGoodsAsync(dataGridSG);
        }
    }
}
