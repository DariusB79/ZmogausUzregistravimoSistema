using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZmogausUzregistravimoSistema.Interfaces;

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





    }
}
