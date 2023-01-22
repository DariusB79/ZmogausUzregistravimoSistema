using ZmogausUzregistravimoSistema.Clases;
using ZmogausUzregistravimoSistema.Interfaces;
using ZmogausUzregistravimoSistema.RequestModels;

namespace ZmogausUzregistravimoSistema.Repositories
{
    public class PersonRepo : IPersonRepo
    {

        private readonly RegistrationDbContext _context;


        public PersonRepo(RegistrationDbContext context)
        {
            _context = context;
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

        public Person GetPersonByUserId(int id)
        {
            return _context.Persons.Single(x => x.Id == id);
        }

        public Person AddNewPerson(PersonRequestModel person)
        {
            var newPerson = new Person();
            newPerson.UserId= person.UserId;
            newPerson.Name = person.Name;
            newPerson.Surname = person.Surname;
            newPerson.PersonIdCode = person.PersonIdCode;
            newPerson.PhoneNr = person.PhoneNr;
            newPerson.Email = person.Email;
            newPerson.Picture = person.Picture;
      
            _context.Persons.Add(newPerson);
            _context.SaveChanges();

            return newPerson;
        }


        public Person UpdatePerson(int id, PersonRequestModel person)
        {

            var personToUpdate = _context.Persons.Single(x => x.Id == id);
            personToUpdate.UserId = personToUpdate.UserId;
            personToUpdate.Name = person.Name;
            personToUpdate.Surname = person.Surname;
            personToUpdate.PersonIdCode = person.PersonIdCode;
            personToUpdate.PhoneNr = person.PhoneNr;
            personToUpdate.Email = person.Email;
            personToUpdate.Picture = person.Picture;
           
            _context.SaveChanges();

            return personToUpdate;
        }

        public Person DeletePerson(int id)
        {
            var delPerson = _context.Persons.Single(x => x.Id == id);
            _context.Persons.Remove(delPerson);
            _context.SaveChanges();

            return delPerson;

        }

        // Updte Person information


        public Person UpdatePersonUserId(int id, int userId)
        {
            var personUpdateUserId = _context.Persons.Single(x => x.Id == id);
            personUpdateUserId.UserId = userId;
            _context.SaveChanges();

            return personUpdateUserId;
        }

        public Person UpdatePersonName(int id, string name)
        {
            var personNameUpdate = _context.Persons.Single(x => x.Id == id);
            personNameUpdate.Name = name;
            _context.SaveChanges();
            return personNameUpdate;

        }

        public Person UpdatePersonSurname(int id, string surname)
        {
            var personSurnameUpdate = _context.Persons.Single(x => x.Id == id);
            personSurnameUpdate.Surname = surname;
            _context.SaveChanges();

            return personSurnameUpdate;

        }

        public Person UpdatePersonIdCode(int id, int idcode)
        {
            var personIdCodeUpdate = _context.Persons.Single(x => x.Id == id);
            personIdCodeUpdate.PersonIdCode = idcode;
            _context.SaveChanges();

            return personIdCodeUpdate;

        }

        public Person UpdatePersonPhoneNumber(int id, int phoneNumber)
        {
            var personPhoneNrUpdate = _context.Persons.Single(x => x.Id == id);
            personPhoneNrUpdate.PhoneNr = phoneNumber;
            _context.SaveChanges();

            return personPhoneNrUpdate;

        }

        public Person UpdatePersonEmail(int id, string email)
        {
            var personEmailUpdate = _context.Persons.Single(x => x.Id == id);
            personEmailUpdate.Email = email;
            _context.SaveChanges();

            return personEmailUpdate;

        }


        public Person UpdatePersonPicture(int id, byte[] picture)
        {
            var personPictureUpdate = _context.Persons.Single(x => x.Id == id);
            personPictureUpdate.Picture = picture;
            _context.SaveChanges();

            return personPictureUpdate;

        }

  
    }
}
