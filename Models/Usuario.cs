namespace apiweb.Models
{
    public class Usuario
    {
        public string Username { get; set; }
        public string Pass { get; set; }

        public Usuario(string username, string pass)
        {
            Username = username;
            Pass = pass;
        }
    }
}