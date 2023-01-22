using ZmogausUzregistravimoSistema.Clases;
using ZmogausUzregistravimoSistema.RequestModels;

namespace ZmogausUzregistravimoSistema.Interfaces
{
    public interface IPersonRepo
    {

        // Person 

        List<Person> GetAllPersons();

        List<Person> GetPersonById(int id);

        Person AddNewPerson(PersonRequestModel person);


        Person UpdatePerson(int id, PersonRequestModel person);

        Person DeletePerson(int id);




        // Updte Person information

        public Person UpdatePersonUserId(int id, int userId);

        public Person UpdatePersonName(int id, string name);

        public Person UpdatePersonSurname(int id, string surname);

        public Person UpdatePersonIdCode(int id, int idcode);

        public Person UpdatePersonPhoneNumber(int id, int phoneNumber);

        public Person UpdatePersonEmail(int id, string email);

        public Person UpdatePersonPicture(int id, byte[] picture);


    }
}
