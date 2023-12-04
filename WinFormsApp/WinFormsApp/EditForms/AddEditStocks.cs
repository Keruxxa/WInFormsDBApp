using System.Data.SqlClient;
using WinFormsApp.Classes;

namespace WinFormsApp.Forms
{
    public partial class AddEditStocks : Form
    {
        DataBase dataBase = new();

        public bool AddMode { get; set; }
        public DataGridView DataGrid { get; set; }

        public AddEditStocks(DataGridView dataGrid, string buttonName, bool addMode)
        {
            InitializeComponent();
            buttonStockAccept.Text = buttonName;
            AddMode = addMode;
            DataGrid = dataGrid;
        }

        private void buttonStockCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        string queryString = """
                SELECT S.Stock_Id as Stock_ID, 
                       S.Stock_Name AS Наименование,
                	   S.Stock_Category AS Категория,
                	   S.Stock_Address AS Адрес
                FROM Stocks S
                """;

        private void AddEditStock_Load(object sender, EventArgs e)
        {
            if (!AddMode)
            {
                int index = DataGrid.CurrentCell.RowIndex;
                textBoxStockName.Text = DataGrid.Rows[index].Cells[1].Value.ToString();
                textBoxStockAddress.Text = DataGrid.Rows[index].Cells[3].Value.ToString();

                char value = Convert.ToChar(DataGrid.Rows[index].Cells[2].Value);
                switch (value)
                {
                    case 'A':
                        index = 0;
                        break;
                    case 'B':
                        index = 1;
                        break;
                    case 'C':
                        index = 2;
                        break;
                    case 'D':
                        index = 3;
                        break;
                }
                comboBoxCategory.SelectedIndex = index;
            }
            else
                comboBoxCategory.SelectedIndex = 0;
        }

        private void buttonStockAccept_Click(object sender, EventArgs e)
        {
            if (textBoxStockName.Text == string.Empty ||
                textBoxStockAddress.Text == string.Empty)
            {
                MessageBox.Show("Все поля должны быть заполнены!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (AddMode)
            {
                try
                {
                    int index = comboBoxCategory.SelectedIndex;

                    Stocks stock = new Stocks()
                    {
                        Name = textBoxStockName.Text,
                        Category = Convert.ToChar(comboBoxCategory.Items[index]),
                        Address = textBoxStockAddress.Text,
                    };

                    dataBase.OpenConnection();

                    string insertQueryString = $"INSERT INTO Stocks (Stock_Name, Stock_Category, Stock_Address)" +
                                         $"VALUES ('{stock.Name}', '{stock.Category}', '{stock.Address}')";

                    var command = new SqlCommand(insertQueryString, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    dataBase.CloseConnection();

                    MessageBox.Show("Склад был успешно добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataGrid.Rows.Clear();
                    DataGridPerformer.FillColumnsStocks(DataGrid, dataBase, queryString);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Склад уже существует, или введенные данные неверны!", "Ошибка!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int index = DataGrid.CurrentCell.RowIndex;
                int id = Convert.ToInt32(DataGrid.Rows[index].Cells[0].Value);

                index = comboBoxCategory.SelectedIndex;

                try
                {
                    Stocks good = new Stocks()
                    {
                        ID = id.ToString(),
                        Name = textBoxStockName.Text,
                        Category = Convert.ToChar(comboBoxCategory.Items[index]),
                        Address = textBoxStockAddress.Text,
                    };

                    dataBase.OpenConnection();

                    string insertQueryString = $"""
                        UPDATE Stocks
                        SET Stocks.Stock_Name = '{good.Name}',
                        	Stocks.Stock_Category = '{good.Category}',
                        	Stocks.Stock_Address = '{good.Address}'
                        WHERE Stocks.Stock_Id = {good.ID}
                        """;

                    var command = new SqlCommand(insertQueryString, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    dataBase.CloseConnection();

                    MessageBox.Show("Склад был успешно изменен!", "Внимание!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DataGrid.Rows.Clear();
                    DataGridPerformer.FillColumnsStocks(DataGrid, dataBase, queryString);
                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Изменение прошло неудачно! Данный склад существует, или введенные данные неверны!",
                                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
