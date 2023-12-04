using System.Data.SqlClient;

namespace WinFormsApp.Classes
{
    public class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=KERUXXA\SQLEXPRESS;Initial Catalog=Warehouse;
                                                      Integrated Security=True; TrustServerCertificate=True");

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
