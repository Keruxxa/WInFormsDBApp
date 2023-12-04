using WinFormsApp.Classes;

namespace WinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm(User user)
        {
            InitializeComponent();
            CreateColumnsSupplies(dataGridSupplies);
            DataGridPerformer.FillColumnsSupplies(dataGridSupplies, dataBase, queryString);
            User = user;
        }

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

        private void buttonGoods_Click(object sender, EventArgs e)
        {
            var goodsForm = new GoodsForm(this, User);
            goodsForm.Show();
        }

        private void buttonStocks_Click(object sender, EventArgs e)
        {
            var stocksForm = new StocksForm(this, User);
            stocksForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stocksForm = new ProvidersForm(this, User);
            stocksForm.Show();
        }

        private void buttonAddSupply_Click(object sender, EventArgs e)
        {
            var addSupply = new AddSupply(dataGridSupplies);
            addSupply.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var stocksGoods = new StocksGoodsForm(this, User);
            stocksGoods.Show();
        }

        private async void btnPrintSupplies_Click(object sender, EventArgs e)
        {
            await Printer.PrintSuppliesAsync(dataGridSupplies);
        }
    }
}