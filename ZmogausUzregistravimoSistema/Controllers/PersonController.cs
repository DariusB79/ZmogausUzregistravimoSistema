using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZmogausUzregistravimoSistema.Clases;
using ZmogausUzregistravimoSistema.Interfaces;
using ZmogausUzregistravimoSistema.Repositories;
using ZmogausUzregistravimoSistema.RequestModels;

namespace ZmogausUzregistravimoSistema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepo _personRepo;

        public PersonController(IPersonRepo personRepo)
        {
            _personRepo = personRepo;
        }


        //Person 

        [HttpGet("GetAllPersons")]
        public List<Person> GetAllPersons()
        {
            return _personRepo.GetAllPersons();
        }

        [HttpGet("GetPersonById")]
        public List<Person> GetPersonById([FromQuery] int id)
        {
            return _personRepo.GetPersonById(id);
        }


        [HttpPost("AddNewPerson")]
        public Person AddNewPerson([FromBody] PersonRequestModel person)
        {
            return _personRepo.AddNewPerson(person);
        }


        [HttpPut("UpdatePerson")]
        public Person UpdatePerson([FromQuery] int id, [FromBody] PersonRequestModel person)
        {
            return _personRepo.UpdatePerson(id, person);
        }


        [HttpDelete("DeletePerson")]
        public Person DeletePerson([FromQuery] int id)
        {
            return _personRepo.DeletePerson(id);
        }


        // Updte Person information

        [HttpPut("UpdatePersonUserid")]
        public Person UpdatePersonUserId([FromQuery] int id, [FromQuery] int userId)
        {
            return _personRepo.UpdatePersonUserId(id, userId);
        }


        [HttpPut("UpdatePersonName")]
        public Person UpdatePersonName([FromQuery] int id, [FromQuery] string name)
        {
            return _personRepo.UpdatePersonName(id, name);
        }

        [HttpPut("UpdatePersonSurname")]
        public Person UpdatePersonSurname([FromQuery] int id, [FromQuery] string surname)
        {
            return _personRepo.UpdatePersonSurname(id, surname);
        }


        [HttpPut("UpdatePersonIdCode")]
        public Person UpdatePersonIdCode([FromQuery] int id, [FromQuery] int idcode)
        {
            return _personRepo.UpdatePersonIdCode(id, idcode);
        }

        [HttpPut("UpdatePersonPhoneNumber")]
        public Person UpdatePersonPhoneNumber([FromQuery] int id, [FromQuery] int phoneNumber)
        {
            return _personRepo.UpdatePersonPhoneNumber(id, phoneNumber);
        }


        [HttpPut("UpdatePersonEmail")]
        public Person UpdatePersonEmail([FromQuery] int id, [FromQuery] string email)
        {
            return _personRepo.UpdatePersonEmail(id, email);
        }


        [HttpPut("UpdatePersonPicture")]
        public Person UpdatePersonPicture([FromQuery] int id, [FromQuery] byte[] picture)
        {
            return _personRepo.UpdatePersonPicture(id, picture);
        }

    }
}
