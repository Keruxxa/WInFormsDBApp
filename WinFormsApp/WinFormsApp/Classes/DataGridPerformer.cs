namespace WinFormsApp.Classes
{
    public static class DataGridPerformer
    {
        public static void FillColumnsGoods(DataGridView dataGridGoods, DataBase dataBase, string query)
        {
            List<Goods> goods = Goods.FillGoods(dataBase, query);

            for (int i = 0; i < goods.Count; i++)
            {
                dataGridGoods.Rows.Add(goods[i].ID, goods[i].Category, goods[i].Name, goods[i].Description, goods[i].UnitPrice);
            }
        }

        public static void FillColumnsStocks(DataGridView dataGridStocks, DataBase dataBase, string query)
        {
            List<Stocks> stocks = Stocks.FillStocks(dataBase, query);

            for (int i = 0; i < stocks.Count; i++)
            {
                dataGridStocks.Rows.Add(stocks[i].ID, stocks[i].Name, stocks[i].Category, stocks[i].Address);
            }
        }

        public static void FillColumnsProviders(DataGridView dataGridStocks, DataBase dataBase, string query)
        {
            List<Provider> providers = Provider.FillProviders(dataBase, query);

            for (int i = 0; i < providers.Count; i++)
            {
                dataGridStocks.Rows.Add(providers[i].ID, providers[i].Name, providers[i].Address, providers[i].Phone);
            }
        }

        public static void FillColumnsSupplies(DataGridView dataGridSupplies, DataBase dataBase, string query)
        {
            List<Suppply> supplies = Suppply.FillSupplies(dataBase, query);

            for (int i = 0; i < supplies.Count; i++)
            {
                dataGridSupplies.Rows.Add(supplies[i].ID,
                                          supplies[i].GoodName,
                                          supplies[i].ProviderName,
                                          supplies[i].StockName,
                                          supplies[i].GoodAmount,
                                          supplies[i].GoodPrice,
                                          supplies[i].SupplyDate);
            }
        }

        public static void FillColumnsStocksGoods(DataGridView dataGridStocksGoods, DataBase dataBase, string query)
        {
            List<StocksGoods> stocksGoods = StocksGoods.FillStocksGoods(dataBase, query);

            for (int i = 0; i < stocksGoods.Count; i++)
            {
                dataGridStocksGoods.Rows.Add(stocksGoods[i].Category,
                                             stocksGoods[i].Good,
                                             stocksGoods[i].Stock,
                                             stocksGoods[i].Amount,
                                             stocksGoods[i].Price);
            }
        }
    }
}
