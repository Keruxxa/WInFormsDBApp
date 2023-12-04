using System.Data.SqlClient;

namespace WinFormsApp.Classes
{
    public class Provider
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Provider(string id, string name, string address, string phone)
        {
            ID = id;
            Name = name;
            Address = address;
            Phone = phone;
        }

        public Provider() { }

        public static List<Provider> FillProviders(DataBase dataBase, string query)
        {
            dataBase.OpenConnection();

            var providers = new List<Provider>();

            var command = new SqlCommand(query, dataBase.GetConnection());

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                providers.Add(new Provider
                {
                    ID = reader["Provider_Id"].ToString() ?? "",
                    Name = reader["Наименование"] as string ?? "",
                    Address = reader["Адрес"] as string ?? "",
                    Phone = reader["Телефон"] as string ?? "",
                });
            }

            dataBase.CloseConnection();

            return providers;
        }
    }
}
