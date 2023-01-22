using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZmogausUzregistravimoSistema.Clases;
using ZmogausUzregistravimoSistema.Interfaces;
using ZmogausUzregistravimoSistema.RequestModels;

namespace ZmogausUzregistravimoSistema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _userRepo;

        public UserController(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        //User


        [HttpGet("GetAllUsers")]
        public List<User> GetAllUsers()
        {
            return _userRepo.GetAllUsers();
        }


        [HttpGet("GetUserByID")]
        public List<User> GetUserById([FromQuery] int id)
        {
            return _userRepo.GetUserById(id);
        }


        [HttpPost("AddNewUser")]
        public User AddNewUser(UserRequestModel user)
        {
            return _userRepo.AddNewUser(user);
        }


        [HttpPut("UpdateUser")]
        public User UpdateUser([FromQuery] int id, [FromBody] UserRequestModel user)
        {
            return _userRepo.UpdateUser(id, user);
        }


        [HttpDelete("DeleteUser")]
        public User DeleteUser([FromQuery] int id)
        {
            return _userRepo.DeleteUser(id);
        }

    }
}
