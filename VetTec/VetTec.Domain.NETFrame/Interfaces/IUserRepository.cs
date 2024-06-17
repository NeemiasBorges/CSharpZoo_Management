using VetTec.Domain.NETFrame.Entities;

namespace VetTec.Domain.NETFrame.Interfaces
{
    public interface IUserRepository
    {
        public bool Login(string email, string senha);
        public Task<IEnumerable<UserDB>> GetUsers();
        public Task<UserDB> GetUserByEmail(string email);
        public Task AddUser(UserDB user);
        public Task UpdateUser(UserDB user);
        public Task DeleteUser(string email);
    }
}
