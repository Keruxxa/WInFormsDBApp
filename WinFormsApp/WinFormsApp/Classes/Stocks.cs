using System.Data.SqlClient;

namespace WinFormsApp.Classes
{
    public class Stocks
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public char Category { get; set; }
        public string Address { get; set; }

        public Stocks(string id, string name, char category, string address)
        {
            ID = id;
            Name = name;
            Category = category;
            Address = address;
        }

        public Stocks() { }

        public static List<Stocks> FillStocks(DataBase dataBase, string query)
        {
            dataBase.OpenConnection();

            var stocks = new List<Stocks>();

            var command = new SqlCommand(query, dataBase.GetConnection());

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                stocks.Add(new Stocks
                {
                    ID = reader["Stock_Id"].ToString() ?? "",
                    Name = reader["Наименование"] as string ?? "",
                    Category = Convert.ToChar(reader["Категория"]),
                    Address = reader["Адрес"] as string ?? ""
                });
            }

            dataBase.CloseConnection();

            return stocks;
        }
    }
}
