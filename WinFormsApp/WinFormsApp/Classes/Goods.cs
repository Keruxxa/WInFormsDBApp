using System.Data.SqlClient;

namespace WinFormsApp.Classes
{
    public class Goods
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string UnitPrice { get; set; }

        public Goods(string id, string name, string category, string description, string unitPrice)
        {
            ID = id;
            Name = name;
            Category = category;
            Description = description;
            UnitPrice = unitPrice;
        }

        public Goods() { }


        public static List<Goods> FillGoods(DataBase dataBase, string query)
        {
            dataBase.OpenConnection();

            var goods = new List<Goods>();

            var command = new SqlCommand(query, dataBase.GetConnection());

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                goods.Add(new Goods
                {
                    ID = reader["Good_ID"].ToString() ?? "",
                    Category = reader["Категория"] as string ?? "",
                    Name = reader["Наименование"] as string ?? "",
                    Description = reader["Описание"] as string ?? "",
                    UnitPrice = reader["Цена"].ToString() ?? ""
                });
            }
            dataBase.CloseConnection();

            return goods;
        }

        public static List<Goods> FillGoodsSearch(DataBase dataBase, string query)
        {
            dataBase.OpenConnection();

            var goods = new List<Goods>();

            var command = new SqlCommand(query, dataBase.GetConnection());

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                goods.Add(new Goods
                {
                    ID = reader["Good_ID"].ToString() ?? "",
                    Category = reader["Категория"] as string ?? "",
                    Name = reader["Наименование"] as string ?? "",
                    Description = reader["Описание"] as string ?? "",
                    UnitPrice = reader["Цена"] as string ?? ""
                });
            }
            dataBase.CloseConnection();

            if (goods != null)
                return goods;
            else
                return null;
        }
    }
}
