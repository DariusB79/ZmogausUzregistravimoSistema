using Microsoft.EntityFrameworkCore;
using ZmogausUzregistravimoSistema.Clases;
using ZmogausUzregistravimoSistema.RequestModels;

namespace ZmogausUzregistravimoSistema.Interfaces
{
    public interface IRegistrationRepo
    {

        // User
        List<User> GetAllUsers();

        List<User> GetUserById(int id);

        User AddNewUser(UserRequestModel user);


        User UpdateUser(int id, UserRequestModel user);

        User DeleteUser(int id);


        // Person 

        List<Person> GetAllPersons();

        List<Person> GetPersonById(int id);

        User AddNewPerson(PersonRequestModel person);


        Person UpdatePerson(int id, PersonRequestModel person);

        Person DeletePerson(int id);




        // Updte Person information

        public Person UpdatePersonName(int id, string name);


        public Person UpdatePersonSurname(int id, string surname);


        public Person UpdatePersonPhoneNumber(int id, int phoneNumber);


        public Person UpdatePersonEmail(int id, string email);


        public Person UpdatePersonPicture(int id, string picture);




        // Place

        List<Place> GetAllPlaces();

        List<Place> GetPlaceById(int id);

        Place AddNewPlace(PlaceRequestModel place);


        Place UpdatePlace(int id, PlaceRequestModel place);

        Place  DeletePlace(int id);




    // Update Place information


    public Place UpdatePlaceCity(int id, string city);


    public Place UpdatePlaceStreet(int id, string street);

    public Place UpdatePlaceHomeNr(int id, int homeNr);


    public Place UpdatePlaceFlatNr(int id, int flatNr);

}

}
