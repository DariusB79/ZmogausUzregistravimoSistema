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



        //Person 




        [HttpGet("GetAllPersons")]
        public List<Person> GetAllPersons()
        {
            return _registrationRepo.GetAllPersons();
        }


        [HttpGet("GetPersonByID")]
        public List<Person> GetPersonById([FromQuery] int id)
        {
            return _registrationRepo.GetPersonById(id);
        }


        [HttpPost("AddNewPerson")]
        public Person AddNewPerson([FromBody] PersonRequestModel person)
        {
            return _registrationRepo.AddNewPerson(person);
        }


        [HttpPut("UpdatePerson")]
        public Person UpdatePerson([FromQuery] int id, [FromBody] PersonRequestModel person)
        {
            return _registrationRepo.UpdatePerson(id, person);
        }


        [HttpDelete("DeletePerson")]
        public Person DeletePerson([FromQuery] int id)
        {
            return _registrationRepo.DeletePerson(id);
        }


        //Update Person informations



        [HttpPut("UpdatePersonName")]
        public Person UpdatePersonName([FromQuery] int id, [FromQuery] string name)
         {
            return _registrationRepo.UpdatePersonName(id, name);
         }

        [HttpPut("UpdatePersonSurname")]
        public Person UpdatePersonSurname([FromQuery] int id, [FromQuery] string surname)
        {
            return _registrationRepo.UpdatePersonSurname(id, surname);
        }


        [HttpPut("UpdatePersonIdCode")]
        public Person UpdatePersonIdCode([FromQuery] int id, [FromQuery] int idcode)
        {
            return _registrationRepo.UpdatePersonIdCode(id, idcode);
            
        }



        [HttpPut("UpdatePersonPhoneNr")]
        public Person UpdatePersonPhoneNumber([FromQuery] int id, [FromQuery] int phoneNumber)
        {
            return _registrationRepo.UpdatePersonPhoneNumber( id, phoneNumber);
        }


        [HttpPut("UpdatePersonEmail")]
        public Person UpdatePersonEmail([FromQuery] int id, [FromQuery] string email)
        {
            return _registrationRepo.UpdatePersonEmail(id, email);
        }


        [HttpPut("UpdatePersonPicture")]
        public Person UpdatePersonPicture([FromQuery] int id, [FromQuery] string picture)
        {
            return _registrationRepo.UpdatePersonPicture(id, picture);
        }



        //Place



        [HttpGet("GetAllPlaces")]
        public List<Place> GetAllPlaces()
        {
            return _registrationRepo.GetAllPlaces();
        }


        [HttpGet("GetPlaceByID")]
        public List<Place> GetPlaceById([FromQuery] int id)
        {
            return _registrationRepo.GetPlaceById(id);
        }


        [HttpPost("AddNewPlace")]
        public Place AddNewPlace(PlaceRequestModel place)
        {
            return _registrationRepo.AddNewPlace(place);
        }


        [HttpPut("UpdatePlace")]
        public Place UpdatePlace([FromQuery] int id, [FromBody] PlaceRequestModel place)
        {
            return _registrationRepo.UpdatePlace(id, place);
        }


        [HttpDelete("DeletePlace")]
        public Place DeletePlace([FromQuery] int id)
        {
            return _registrationRepo.DeletePlace(id);
        }




        // Update Place information


        [HttpPut("UpdatePlaceCity")]
        public Place UpdatePlaceCity([FromQuery] int id, [FromQuery] string city)
        {
            return _registrationRepo.UpdatePlaceCity(id, city);
        }

        [HttpPut("UpdatePlaceStreet")]
        public Place UpdatePlaceStreet([FromQuery] int id, [FromQuery] string street)
        {
            return _registrationRepo.UpdatePlaceStreet(id, street);
        }

        [HttpPut("UpdatePlaceHomeNr")]
        public Place UpdatePlaceHomeNr([FromQuery] int id, [FromQuery] int homeNr)
        {
            return _registrationRepo.UpdatePlaceHomeNr(id, homeNr);
        }


        [HttpPut("UpdatePlaceFlatNr")]
        public Place UpdatePlaceFlatNr([FromQuery] int id, [FromQuery] int flatNr)
        {
            return _registrationRepo.UpdatePlaceFlatNr(id, flatNr);
        }



    }
}
