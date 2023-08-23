namespace Api_login_Dicsys.Models
{
    public class Usuario
    {
        public Usuario(string UserName, string Password, string Mail, int Dni )
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Mail = Mail;
            this.Dni = Dni;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public int Dni { get; set; }

    }
}
