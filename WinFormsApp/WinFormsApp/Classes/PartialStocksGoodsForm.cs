using WinFormsApp.Classes;

namespace WinFormsApp
{
    public partial class StocksGoodsForm : Form
    {
        private void StocksGoodsForm_Load(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridSG.Rows.Count; i++)
            {
                sum += Convert.ToInt32(dataGridSG.Rows[i].Cells[4].Value);
            }
            labelSum.Text += $"{sum} руб.";
            unloadGood.Enabled = User.IsAdmin;
            buttonMove.Enabled = User.IsAdmin;
            ParentForm.Visible = false;
        }


        private void StocksGoodsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm.Visible = true;
        }

        public void CreateColumns(DataGridView dataGridSG)
        {
            dataGridSG.Columns.Add("Good_Category", "Категория");
            dataGridSG.Columns.Add("Good_Name", "Товар");
            dataGridSG.Columns.Add("Stock_Name", "Склад");
            dataGridSG.Columns.Add("Good_Amount", "Количество");
            dataGridSG.Columns.Add("Price", "Стоимость");
            dataGridSG.Columns[0].Width = 170;
            dataGridSG.Columns[1].Width = 218;
            dataGridSG.Columns[2].Width = 195;
            dataGridSG.Columns[3].Width = 110;
            dataGridSG.Columns[4].Width = 184;
        }

        string queryGoods = """
                SELECT G.Good_Id AS Good_ID,
                	   G.Good_Category AS Категория,
                       G.Good_Name AS Наименование,
                	   G.Good_Description AS Описание,
                       G.Good_UnitPrice AS Цена
                FROM Goods G
                """;

        string queryStocks = """
                SELECT S.Stock_Id AS Stock_Id,
                       S.Stock_Name AS Наименование,
                       S.Stock_Category AS Категория,
                       S.Stock_Address AS Адрес
                FROM Stocks S
                """;

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


        //buttonUnloadGood
        private void unloadGood_MouseEnter(object sender, EventArgs e)
        {
            labelUnload.BackColor = Color.LightGray;
        }

        private void unloadGood_MouseLeave(object sender, EventArgs e)
        {
            labelUnload.BackColor = Color.Transparent;
        }

        private void unloadGood_MouseDown(object sender, MouseEventArgs e)
        {
            labelUnload.BackColor = Color.DarkGray;
        }

        private void unloadGood_MouseUp(object sender, MouseEventArgs e)
        {
            labelUnload.BackColor = Color.LightGray;
        }

        //buttonMoveGood
        private void buttonMove_MouseEnter(object sender, EventArgs e)
        {
            labelMove.BackColor = Color.LightGray;
        }

        private void buttonMove_MouseLeave(object sender, EventArgs e)
        {
            labelMove.BackColor = Color.Transparent;
        }

        private void buttonMove_MouseDown(object sender, MouseEventArgs e)
        {
            labelMove.BackColor = Color.DarkGray;
        }

        private void buttonMove_MouseUp(object sender, MouseEventArgs e)
        {
            labelMove.BackColor = Color.LightGray;
        }
    }
}
