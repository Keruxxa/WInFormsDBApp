using System.Data.SqlClient;
using WinFormsApp.Classes;

namespace WinFormsApp
{
    public partial class AddSupply : Form
    {
        DataBase dataBase = new();
        DataGridView DataGridSupplies;

        public AddSupply(DataGridView dataGridSupplies)
        {
            InitializeComponent();
            FillComboBoxes();
            DataGridSupplies = dataGridSupplies;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
                return;

            int goodAmount = Convert.ToInt32(numericGoodAmount.Value);

            string queryAddSupply = $"""
                DECLARE @good_id INT,
            	    @provider_id INT,
            		@stock_id INT;
                SET @good_id = (Select Goods.Good_Id
                				 From Goods
                				 Where Goods.Good_Name = '{comboBoxGoodName.Text}');
                SET @provider_id = (Select Providers.Provider_Id
                				 From Providers
                				 Where Providers.Provider_Name = '{comboBoxProviderName.Text}');
                SET @stock_id = (Select Stocks.Stock_Id
                				 From Stocks
                				 Where Stocks.Stock_Name = '{comboBoxStockName.Text}');
                INSERT INTO Supply (Good_Id, Provider_Id, Stock_Id, Good_Amount)
            			VALUES (@good_id, @provider_id, @stock_id, {goodAmount})
            """;

            try
            {
                dataBase.OpenConnection();
                var command = new SqlCommand(queryAddSupply, dataBase.GetConnection());
                command.ExecuteNonQuery();
                dataBase.CloseConnection();

                MessageBox.Show("Поставка была успешно добавлена!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataGridSupplies.Rows.Clear();
                DataGridPerformer.FillColumnsSupplies(DataGridSupplies, dataBase, queryString);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введенные данные!", "Ошибка!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool CheckFields()
        {
            if (comboBoxGoodName.SelectedIndex == -1 ||
                comboBoxProviderName.SelectedIndex == -1 ||
                comboBoxStockName.SelectedIndex == -1)
            {
                MessageBox.Show("Поля с наименование товара, склада и поставщика должны быть заполнены!",
                                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (numericGoodAmount.Value == 0)
            {
                MessageBox.Show("Поле с количеством не может быть равно 0!",
                                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void FillComboBoxes()
        {
            var goods = Goods.FillGoods(dataBase, queryGoods);
            var providers = Provider.FillProviders(dataBase, queryProviders);
            var stocks = Stocks.FillStocks(dataBase, queryStocks);

            if (goods != null)
            {
                foreach (var good in goods)
                {
                    comboBoxGoodName.Items.Add(good.Name);
                }
            }

            if (providers != null)
            {
                foreach (var provider in providers)
                {
                    comboBoxProviderName.Items.Add(provider.Name);
                }
            }

            if (stocks != null)
            {
                foreach (var stock in stocks)
                {
                    comboBoxStockName.Items.Add(stock.Name);
                }
            }
        }

        string queryGoods = """
                SELECT G.Good_Id AS Good_ID,
                	   G.Good_Category AS Категория,
                       G.Good_Name AS Наименование,
                	   G.Good_Description AS Описание,
                       G.Good_UnitPrice AS Цена
                FROM Goods G
                """;

        string queryProviders = """
                SELECT P.Provider_Id AS Provider_Id,
                       P.Provider_Name AS Наименование,
                	   P.Provider_Address AS Адрес,
                	   P.Provider_Phone AS Телефон
                FROM Providers P
                """;

        string queryStocks = """
                SELECT S.Stock_Id AS Stock_Id,
                       S.Stock_Name AS Наименование,
                       S.Stock_Category AS Категория,
                       S.Stock_Address AS Адрес
                FROM Stocks S
                """;

        string queryString = """
                SELECT Supply.Supply_Id AS Supply_Id,
                	   Goods.Good_Name AS Наименование_товара,
                       Providers.Provider_Name AS Поставщик,
                       Stocks.Stock_Name AS Склад,
                       Supply.Good_Amount AS Количество,
                       Goods.Good_UnitPrice AS Цена,
                	   Supply.Supply_Date AS Дата
                FROM Supply
                JOIN Goods ON Supply.Good_Id = Goods.Good_Id
                JOIN Providers ON Supply.Provider_Id = Providers.Provider_Id
                JOIN Stocks ON Supply.Stock_Id = Stocks.Stock_Id
                """;
    }
}
