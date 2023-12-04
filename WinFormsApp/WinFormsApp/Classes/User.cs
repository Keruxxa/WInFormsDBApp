namespace WinFormsApp.Classes
{
    public class User
    {
        public string Login { get; set; }
        public bool IsAdmin { get; set; }

        public User(string login, bool isAdmin)
        {
            Login = login;
            IsAdmin = isAdmin;
        }

        public string Status => IsAdmin ? "Администратор" : "Пользователь";
    }
}
