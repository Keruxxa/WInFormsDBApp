using System.Data.SqlClient;
using WinFormsApp.Classes;

namespace WinFormsApp.Forms
{
    public partial class AddEditProviders : Form
    {
        DataBase dataBase = new();

        public bool AddMode { get; set; }
        public DataGridView DataGrid { get; set; }

        public AddEditProviders(string buttonName, DataGridView dataGrid, bool addMode)
        {
            InitializeComponent();
            buttonProvidersAccept.Text = buttonName;
            AddMode = addMode;
            DataGrid = dataGrid;
        }

        private void AddEditProviders_Load(object sender, EventArgs e)
        {
            if (!AddMode)
            {
                int index = DataGrid.CurrentCell.RowIndex;
                textBoxProviderName.Text = DataGrid.Rows[index].Cells[1].Value.ToString();
                textBoxProviderAddress.Text = DataGrid.Rows[index].Cells[2].Value.ToString();
                textBoxProviderPhone.Text = DataGrid.Rows[index].Cells[3].Value.ToString();
            }
        }

        string queryString = """
            SELECT P.Provider_Id AS Provider_Id,
                   P.Provider_Name AS Наименование,
            	   P.Provider_Address AS Адрес,
            	   P.Provider_Phone AS Телефон
            FROM Providers P
            """;

        private void buttonProvidersCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonProvidersAccept_Click(object sender, EventArgs e)
        {
            if (textBoxProviderName.Text == string.Empty ||
                textBoxProviderAddress.Text == string.Empty ||
                textBoxProviderPhone.Text == string.Empty)
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (AddMode)
            {
                try
                {
                    Provider provider = new Provider()
                    {
                        Name = textBoxProviderName.Text,
                        Address = textBoxProviderAddress.Text,
                        Phone = textBoxProviderPhone.Text,
                    };

                    dataBase.OpenConnection();

                    string insertQueryString = $"INSERT INTO Providers (Provider_Name, Provider_Address, Provider_Phone)" +
                                         $"VALUES ('{provider.Name}', '{provider.Address}', '{provider.Phone}')";

                    var command = new SqlCommand(insertQueryString, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    dataBase.CloseConnection();

                    MessageBox.Show("Поставщик был успешно добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataGrid.Rows.Clear();
                    DataGridPerformer.FillColumnsProviders(DataGrid, dataBase, queryString);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Поставщик уже существует, или введенные данные неверны!", "Ошибка!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int index = DataGrid.CurrentCell.RowIndex;
                int id = Convert.ToInt32(DataGrid.Rows[index].Cells[0].Value);
                try
                {
                    Provider provider = new Provider()
                    {
                        ID = id.ToString(),
                        Name = textBoxProviderName.Text,
                        Address = textBoxProviderAddress.Text,
                        Phone = textBoxProviderPhone.Text,
                    };

                    dataBase.OpenConnection();

                    string insertQueryString = $"""
                        UPDATE Providers
                        SET Providers.Provider_Name = '{provider.Name}',
                        	Providers.Provider_Address = '{provider.Address}',
                        	Providers.Provider_Phone = '{provider.Phone}'
                        WHERE Providers.Provider_Id = {provider.ID}
                        """;

                    var command = new SqlCommand(insertQueryString, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    dataBase.CloseConnection();

                    MessageBox.Show("Поставщик был успешно изменен!", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataGrid.Rows.Clear();
                    DataGridPerformer.FillColumnsProviders(DataGrid, dataBase, queryString);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Изменение прошло неудачно! Данный поставщик существует, или введенные данные неверны!",
                                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
