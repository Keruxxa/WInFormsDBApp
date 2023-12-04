using System.Data.SqlClient;

namespace WinFormsApp.Classes
{
    internal class StocksGoods
    {
        public string Category { get; set; }
        public string Good { get; set; }
        public string Stock { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }

        public StocksGoods(string category, string good, string stock, int amount, int price)
        {
            Category = category;
            Good = good;
            Stock = stock;
            Amount = amount;
            Price = price;
        }

        public StocksGoods() { }

        public static List<StocksGoods> FillStocksGoods(DataBase dataBase, string query)
        {
            dataBase.OpenConnection();

            var stocksGoods = new List<StocksGoods>();

            var command = new SqlCommand(query, dataBase.GetConnection());

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                stocksGoods.Add(new StocksGoods
                {
                    Category = reader["Категория"] as string ?? "",
                    Good = reader["Товар"] as string ?? "",
                    Stock = reader["Склад"] as string ?? "",
                    Amount = (int)reader["Количество"],
                    Price = (int)reader["Стоимость"]
                });
            }

            dataBase.CloseConnection();

            return stocksGoods;
        }
    }
}
