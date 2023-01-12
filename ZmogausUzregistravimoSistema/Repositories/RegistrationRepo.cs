using Microsoft.EntityFrameworkCore;
using ZmogausUzregistravimoSistema.Clases;
using ZmogausUzregistravimoSistema.Interfaces;
using ZmogausUzregistravimoSistema.RequestModels;

namespace ZmogausUzregistravimoSistema.Repositories
{
    public class RegistrationRepo : IRegistrationRepo
    {
        //  private readonly List<User> _users = new();

        // private readonly List <Person> _persons= new();

        // private readonly List<Place> _places = new(); 


        private readonly RegistrationDbContext _context;


        public RegistrationRepo(RegistrationDbContext context) 
        {
            _context= context;
        }

        //User

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public List<User> GetUserById(int id)
        {
            return _context.Users.Where(x => x.Id == id).ToList();
        }

        public User AddNewUser(UserRequestModel user)
        {
            var newUser = new User();
            newUser.Name = user.Name;
            newUser.Password = user.Password;
            newUser.Role = user.Role;
            _context.Users.Add(newUser);
            _context.SaveChanges(); 
          
            return newUser;
        }

        public User UpdateUser(int id, UserRequestModel user)
        {
         
            var userToUpdate = _context.Users.Where(x => x.Id == id);
            userToUpdate.Name = user.Name;
            userToUpdate.Password = user.Password;
            userToUpdate.Role = user.Role;
            _context.Users.Add(userToUpdate);
            _context.SaveChanges();

            return userToUpdate;
        }

        public User DeleteUser(int id)
        {
            var delUser = _context.Users.Single(x => x.Id == id);
            _context.Users.Remove(delUser);

            return delUser;

        }


        //Person 

        public List<Person> GetAllPersons()
        {
            return _context.Persons.ToList();
        }


        public List<Person> GetPersonById(int id)
        {
            return _context.Persons.Where(x => x.Id == id).ToList();
        }


        public Person AddNewPerson(PersonRequestModel person)
        {
            var newPerson = new Person();
            newPerson.Name = person.Name;
            newPerson.Surname = person.Surname;   
            newPerson.PersonIdCode= person.PersonIdCode;
            newPerson.PhoneNr = person.PhoneNr;
            newPerson.Email = person.Email;
            newPerson.Picture = person.Picture;
            newPerson.Places= person.Places;
            _context.Persons.Add(newPerson);
            _context.SaveChanges();

            return newPerson;
        }


        public Person UpdatePerson(int id, PersonRequestModel person)
        {

            var personToUpdate = _context.Persons.Where(x => x.Id == id);
            personToUpdate.Name = person.Name;
            personToUpdate.Surname = person.Surname;
            personToUpdate.PersonIdCode = person.PersonIdCode;
            personToUpdate.PhoneNr = person.PhoneNr;
            personToUpdate.Email = person.Email;
            personToUpdate.Picture = person.Picture;
            personToUpdate.Places = person.Places;
            _context.Persons.Add(personToUpdate);
            _context.SaveChanges();

            return personToUpdate;
        }

        public Person DeletePerson(int id)
        {
            var delPerson = _context.Persons.Single(x => x.Id == id);
            _context.Persons.Remove(delPerson);

            return delPerson;

        }


        //Place

        public List<Place> GetAllPlaces()
        {
            return _context.Places.ToList();
        }


        public List<Place> GetPlacesById(int id)
        {
            return _context.Places.Where(x => x.Id == id).ToList();
        }


        public Place AddNewPlace(PlaceRequestModel place)
        {
            var newPlace = new Place();
            newPlace.PersonId = place.PersonId;
            newPlace.City = place.City;
            newPlace.Street = place.Street;
            newPlace.HomeNr = place.HomeNr;
            newPlace.FlatNr = place.FlatNr;
            _context.Places.Add(newPlace);
            _context.SaveChanges();

            return newPlace;
        }



        public Place UpdatePlace(int id, PlaceRequestModel place)
        {

            var placeToUpdate = _context.Places.Where(x => x.Id == id);
            placeToUpdate.PersonId = place.PersonId;
            placeToUpdate.City = place.City;
            placeToUpdate.Street = place.Street;
            placeToUpdate.HomeNr = place.HomeNr;
            placeToUpdate.FlatNr = place.FlatNr;
            _context.Places.Add(placeToUpdate);
            _context.SaveChanges();

            return placeToUpdate;
        }


        public Place DeletePlace(int id)
        {
            var delPlace = _context.Places.Single(x => x.Id == id);
            _context.Places.Remove(delPlace);

            return delPlace;

        }

    }
}
