using SOLID.SRP.Models;
using SOLID.SRP.Repository;

namespace SOLID.SRP.Service
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            _userRepository.Add(user);
            _userRepository.Save();
        }

        public void RemoveUser(User user)
        {
            _userRepository.Remove(user);  
        }        
    }
}
