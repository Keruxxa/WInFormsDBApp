using System.Data.SqlClient;

namespace WinFormsApp.Classes
{
    public class Suppply
    {
        public string ID { get; set; }
        public string GoodName { get; set; }
        public string ProviderName { get; set; }
        public string StockName { get; set; }
        public string GoodAmount { get; set; }
        public string GoodPrice { get; set; }
        public string SupplyDate { get; set; }

        public Suppply(string id,
                       string goodName,
                       string providerName,
                       string stockName,
                       string goodAmount,
                       string goodPrice,
                       string supplyDate)
        {
            ID = id;
            GoodName = goodName;
            ProviderName = providerName;
            StockName = stockName;
            GoodAmount = goodAmount;
            GoodPrice = goodPrice;
            SupplyDate = supplyDate;
        }

        public Suppply() { }


        public static List<Suppply> FillSupplies(DataBase dataBase, string query)
        {
            dataBase.OpenConnection();

            var suppplies = new List<Suppply>();

            var command = new SqlCommand(query, dataBase.GetConnection());

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                suppplies.Add(new Suppply
                {
                    ID = reader["Supply_Id"].ToString() ?? "",
                    GoodName = reader["Наименование_товара"] as string ?? "",
                    ProviderName = reader["Поставщик"] as string ?? "",
                    StockName = reader["Склад"] as string ?? "",
                    GoodAmount = reader["Количество"].ToString() ?? "",
                    GoodPrice = reader["Цена"].ToString() ?? "",
                    SupplyDate = Convert.ToDateTime(reader["Дата"]).ToShortDateString()
                });
            }

            dataBase.CloseConnection();

            return suppplies;
        }
    }
}
