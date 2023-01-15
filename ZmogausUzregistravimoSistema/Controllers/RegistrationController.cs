using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.ConstrainedExecution;
using ZmogausUzregistravimoSistema.Clases;
using ZmogausUzregistravimoSistema.Interfaces;
using ZmogausUzregistravimoSistema.RequestModels;

namespace ZmogausUzregistravimoSistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {

        private readonly IRegistrationRepo _registrationRepo;


        public RegistrationController(IRegistrationRepo registrationRepo)
        {
            _registrationRepo = registrationRepo;   
        }


        //User


        [HttpGet("GetAllUsers")]
        public List<User> GetAllUsers()
        {
            return _registrationRepo.GetAllUsers();
        }


        [HttpGet("GetUserByID")]
        public List<User> GetUserById([FromQuery]int id)
        {
            return _registrationRepo.GetUserById(id);
        }


        [HttpPost("AddNewUser")]
        public User  AddNewUser(UserRequestModel user)
        {
            return _registrationRepo.AddNewUser(user);
        }


        [HttpPut("UpdateUser")]
        public User UpdateUser([FromQuery] int id, [FromBody] UserRequestModel user)
        {
            return _registrationRepo.UpdateUser(id, user);
        }


        [HttpDelete("DeleteUser")]
        public User  DeleteUser([FromQuery] int id)
        {
            return _registrationRepo.DeleteUser(id);
        }





    }
}
