using WinFormsApp.Classes;

namespace WinFormsApp
{
    public partial class StocksForm : Form
    {
        DataBase dataBase = new();

        public void CreateColumnsStocks(DataGridView dataGridStocks)
        {
            dataGridStocks.Columns.Add("Stock_Id", "ID");
            dataGridStocks.Columns.Add("Stock_Name", "Наименование");
            dataGridStocks.Columns.Add("Stock_City", "Категория");
            dataGridStocks.Columns.Add("Stock_Address", "Адрес");
            dataGridStocks.Columns[0].Width = 40;
            dataGridStocks.Columns[1].Width = 215;
            dataGridStocks.Columns[2].Width = 80;
            dataGridStocks.Columns[3].Width = 420;
        }

        private void textBoxSearchStocks_TextChanged(object sender, EventArgs e)
        {
            dataGridStocks.Rows.Clear();

            string querySearch = $"""
                SELECT S.Stock_Id AS Stock_Id,
                       S.Stock_Name AS Наименование,
                       S.Stock_Category AS Категория,
                       S.Stock_Address AS Адрес
                FROM Stocks S
                WHERE CONCAT(S.Stock_Name,
                             S.Stock_Category,
                             S.Stock_Address)
                LIKE '%{textBoxSearchStocks.Text.Trim()}%'
                """;

            DataGridPerformer.FillColumnsStocks(dataGridStocks, dataBase, querySearch);
        }


        //labelAddStock
        private void buttonAddStock_MouseEnter(object sender, EventArgs e)
        {
            labelAddStock.BackColor = Color.LightGray;
        }

        private void buttonAddStock_MouseLeave(object sender, EventArgs e)
        {
            labelAddStock.BackColor = Color.Transparent;
        }

        private void buttonAddStock_MouseDown(object sender, MouseEventArgs e)
        {
            labelAddStock.BackColor = Color.DarkGray;
        }

        private void buttonAddStock_MouseUp(object sender, MouseEventArgs e)
        {
            labelAddStock.BackColor = Color.LightGray;
        }


        //labelDeleteStock
        private void buttonDeleteStock_MouseEnter(object sender, EventArgs e)
        {
            labelDeleteStock.BackColor = Color.LightGray;
        }

        private void buttonDeleteStock_MouseLeave(object sender, EventArgs e)
        {
            labelDeleteStock.BackColor = Color.Transparent;
        }

        private void buttonDeleteStock_MouseDown(object sender, MouseEventArgs e)
        {
            labelDeleteStock.BackColor = Color.DarkGray;
        }

        private void buttonDeleteStock_MouseUp(object sender, MouseEventArgs e)
        {
            labelDeleteStock.BackColor = Color.LightGray;
        }

        //labelEditStock
        private void buttonEditStock_MouseEnter(object sender, EventArgs e)
        {
            labelEditStock.BackColor = Color.LightGray;
        }

        private void buttonEditStock_MouseLeave(object sender, EventArgs e)
        {
            labelEditStock.BackColor = Color.Transparent;
        }

        private void buttonEditStock_MouseDown(object sender, MouseEventArgs e)
        {
            labelEditStock.BackColor = Color.DarkGray;
        }

        private void buttonEditStock_MouseUp(object sender, MouseEventArgs e)
        {
            labelEditStock.BackColor = Color.LightGray;
        }


        private void StocksForm_Load(object sender, EventArgs e)
        {
            ParentForm.Enabled = false;
            buttonAddStock.Enabled = User.IsAdmin;
            buttonDeleteStock.Enabled = User.IsAdmin;
            buttonEditStock.Enabled = User.IsAdmin;
        }

        private void StocksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm.Enabled = true;
        }
    }
}
