namespace Api_login_Dicsys.Models
{
    public class Login
    {
        public Login(int password, string userName)
        {
            Password = password;
            UserName = userName;
        }

        public int Password { get; set; }
        public string UserName { get; set; }
    }
}
