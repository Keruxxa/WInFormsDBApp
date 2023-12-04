using System.Data.SqlClient;
using WinFormsApp.Classes;
using WinFormsApp.Forms;

namespace WinFormsApp
{
    public partial class StocksForm : Form
    {
        public User User { get; set; }

        public Form ParentForm { get; set; }

        public StocksForm(Form parentForm, User user)
        {
            InitializeComponent();

            ParentForm = parentForm;
            User = user;

            CreateColumnsStocks(dataGridStocks);
            DataGridPerformer.FillColumnsStocks(dataGridStocks, dataBase, queryString);
        }

        string queryString = """
                SELECT S.Stock_Id AS Stock_Id,
                       S.Stock_Name AS Наименование,
                       S.Stock_Category AS Категория,
                       S.Stock_Address AS Адрес
                FROM Stocks S
                """;

        private void buttonDeleteStock_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить склад?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridStocks.CurrentCell.RowIndex;

                int id = Convert.ToInt32(dataGridStocks.Rows[index].Cells[0].Value);

                dataBase.OpenConnection();

                string queryString = $"DELETE FROM Stocks WHERE Stock_Id = {id}";

                var command = new SqlCommand(queryString, dataBase.GetConnection());
                command.ExecuteNonQuery();

                dataBase.CloseConnection();

                MessageBox.Show("Склад был успешно удален!", "Внимание!");

                dataGridStocks.Rows.RemoveAt(index);
                dataGridStocks.Update();
                dataGridStocks.Refresh();
            }
        }

        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            AddEditStocks form = new(dataGridStocks, "Добавить", true);
            form.Show();
        }

        private void buttonEditStock_Click(object sender, EventArgs e)
        {
            AddEditStocks form = new(dataGridStocks, "Изменить", false);
            form.Show();
        }

        private async void btnPrintStocks_Click(object sender, EventArgs e)
        {
            await Printer.PrintStocksAsync(dataGridStocks);
        }
    }
}
