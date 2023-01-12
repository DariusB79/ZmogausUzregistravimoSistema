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

        Person DeletePersonr(int id);


        // Place

        List<Place> GetAllPlaces();

        List<Place> GetPlaceById(int id);

        Place AddNewPlace(PlaceRequestModel place);


        Place UpdatePlace(int id, PlaceRequestModel place);

        Place  DeletePlace(int id);
    }
}
