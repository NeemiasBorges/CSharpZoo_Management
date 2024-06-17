using Microsoft.Data.SqlClient;
using VetTec.Domain.NETFrame.Entities;
using VetTec.Domain.NETFrame.Interfaces;

namespace VetTec.Repository.NETFrame.Repositories
{

    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;
        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task AddUser(UserDB user)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteUser(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDB> GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserDB>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public  bool Login(string email, string senha)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                var cmd = new SqlCommand("SELECT * FROM Users WHERE UPPER(email) = @Email AND UPPER(senha) = @Senha", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senha);

                conn.Open();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return true;
                }
                return false;
            }
        }

        public async Task UpdateUser(UserDB user)
        {
            throw new NotImplementedException();
        }
    }
}
