using ZmogausUzregistravimoSistema.Clases;
using ZmogausUzregistravimoSistema.RequestModels;

namespace ZmogausUzregistravimoSistema.Interfaces
{
    public interface IUserRepo
    {

        // User
        List<User> GetAllUsers();

        List<User> GetUserById(int id);

        User AddNewUser(UserRequestModel user);


        User UpdateUser(int id, UserRequestModel user);

        User DeleteUser(int id);
    }
}
