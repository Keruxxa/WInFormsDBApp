using System.Data.SqlClient;
using WinFormsApp.Classes;

namespace WinFormsApp
{
    public partial class GoodsForm : Form
    {
        public Form ParentForm { get; set; }

        public GoodsForm(Form parentForm, User user)
        {
            InitializeComponent();

            ParentForm = parentForm;
            User = user;

            CreateColumnsGoods(dataGridGoods);
            DataGridPerformer.FillColumnsGoods(dataGridGoods, dataBase, queryString);
        }

        string queryString = """
                SELECT G.Good_Id AS Good_ID,
                	   G.Good_Category AS Категория,
                       G.Good_Name AS Наименование,
                	   G.Good_Description AS Описание,
                       G.Good_UnitPrice AS Цена
                FROM Goods G
                """;


        private void buttonDeleteGood_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить товар?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridGoods.CurrentCell.RowIndex;

                int id = Convert.ToInt32(dataGridGoods.Rows[index].Cells[0].Value);

                dataBase.OpenConnection();

                string queryString = $"DELETE FROM Goods WHERE Good_Id = {id}";

                var command = new SqlCommand(queryString, dataBase.GetConnection());
                command.ExecuteNonQuery();

                dataBase.CloseConnection();

                MessageBox.Show("Товар был успешно удален!", "Внимание!");

                dataGridGoods.Rows.RemoveAt(index);
                dataGridGoods.Update();
                dataGridGoods.Refresh();
            }
        }

        private void buttonEditGood_Click(object sender, EventArgs e)
        {
            AddEditGoods form = new("Изменить", dataGridGoods, false);
            form.Show();
        }

        private void buttonAddGood_Click(object sender, EventArgs e)
        {
            AddEditGoods form = new("Добавить", dataGridGoods, true);
            form.Show();
        }

        private async void btnPrintGoods_Click(object sender, EventArgs e)
        {
            await Printer.PrintGoodsAsync(dataGridGoods);
        }
    }
}
