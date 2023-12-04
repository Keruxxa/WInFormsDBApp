using System.Data;
using System.Data.SqlClient;
using WinFormsApp.Classes;

namespace WinFormsApp
{
    public partial class LoginForm : Form
    {
        DataBase dataBase = new();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string userLogin = textBoxLogin.Text;
            string userPassword = textBoxPassword.Text;

            var adapter = new SqlDataAdapter();
            var table = new DataTable();

            string queryString = $"""
                SELECT Users.User_ID,
                	   Users.Login,
                	   Users.Password,
                	   Users.Admin
                FROM Users
                WHERE Login = '{userLogin}' AND
                	  Password = '{userPassword}'
                """;

            var command = new SqlCommand(queryString, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                bool isAdmin = Convert.ToBoolean(table.Rows[0].ItemArray[3]);
                User user = new User(userLogin, isAdmin);

                MainForm form = new MainForm(user);
                form.Show();
                Hide();
            }
            else
                MessageBox.Show("Введенные данные неверны!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
