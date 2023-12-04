using System.Data.SqlClient;
using WinFormsApp.Classes;
using WinFormsApp.Forms;

namespace WinFormsApp
{
    public partial class ProvidersForm : Form
    {
        public User User { get; set; }

        public Form ParentForm { get; set; }

        public ProvidersForm(Form parentForm, User user)
        {
            InitializeComponent();

            ParentForm = parentForm;
            User = user;

            CreateColumnsProviders(dataGridProviders);
            DataGridPerformer.FillColumnsProviders(dataGridProviders, dataBase, queryString);
        }

        string queryString = """
                SELECT P.Provider_Id AS Provider_Id,
                       P.Provider_Name AS Наименование,
                	   P.Provider_Address AS Адрес,
                	   P.Provider_Phone AS Телефон
                FROM Providers P
                """;

        private void buttonEditProvider_Click(object sender, EventArgs e)
        {
            AddEditProviders form = new("Изменить", dataGridProviders, false);
            form.Show();
        }

        private void buttonAddProvider_Click(object sender, EventArgs e)
        {
            AddEditProviders form = new("Добавить", dataGridProviders, true);
            form.Show();
        }

        private void buttonDeleteProvider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить поставщика?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int index = dataGridProviders.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridProviders.Rows[index].Cells[0].Value);

                dataBase.OpenConnection();

                string queryString = $"DELETE FROM Providers WHERE Provider_Id = {id}";

                var command = new SqlCommand(queryString, dataBase.GetConnection());
                command.ExecuteNonQuery();

                dataBase.CloseConnection();

                MessageBox.Show("Поставщик был успешно удален!", "Внимание!");

                dataGridProviders.Rows.RemoveAt(index);
                dataGridProviders.Update();
                dataGridProviders.Refresh();
            }
        }
    }
}
