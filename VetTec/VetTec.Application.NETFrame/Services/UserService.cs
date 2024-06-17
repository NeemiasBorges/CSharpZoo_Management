using Serilog;
using VetTec.Domain.NETFrame.Interfaces;
using VetTec.Entities;
using VetTec.Entities.Interfaces;
using VetTec.Repository;

namespace VetTec.Application.NETFrame.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger _logger;

        public UserService(IUserRepository userRepository, ILogger logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        public bool Login(string email, string senha)
        {
            bool logged = false;
            try
            {
                logged = _userRepository.Login(email.ToUpper(), senha.ToUpper());
                return logged;
            }
            catch (Exception ex)
            {
                _logger.Information($"Tentativa de Login às {DateTime.Now}");
                throw;
            }
        }
    }
}
