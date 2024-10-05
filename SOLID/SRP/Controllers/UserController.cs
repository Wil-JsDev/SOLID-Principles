using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOLID.SRP.Models;
using SOLID.SRP.Service;

namespace SOLID.SRP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Add")]
        public void Add(User user)
        {
            _userService.AddUser(user);
        }

        [HttpDelete("{id}")]
        public void Delete(User user)
        {
            _userService.RemoveUser(user);
        }
    }
}
