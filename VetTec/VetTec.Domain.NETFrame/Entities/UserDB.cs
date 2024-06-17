
namespace VetTec.Domain.NETFrame.Entities
{
    public class UserDB
    {
        public string email { get; set; }
        public string senha { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is UserDB dB &&
                   senha == dB.senha;
        }
        public UserDB(){}
        public UserDB(string email, string senha)
        {
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.senha = senha ?? throw new ArgumentNullException(nameof(senha));
        }
    }
}
