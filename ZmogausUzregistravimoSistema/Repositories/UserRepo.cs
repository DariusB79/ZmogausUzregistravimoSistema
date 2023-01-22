using ZmogausUzregistravimoSistema.Clases;
using ZmogausUzregistravimoSistema.Interfaces;
using ZmogausUzregistravimoSistema.RequestModels;

namespace ZmogausUzregistravimoSistema.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly RegistrationDbContext _context;


        public UserRepo(RegistrationDbContext context)
        {
            _context = context;
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

            var userToUpdate = _context.Users.Single(x => x.Id == id);
            userToUpdate.Name = user.Name;
            userToUpdate.Password = user.Password;
            userToUpdate.Role = user.Role;
            _context.SaveChanges();

            return userToUpdate;
        }

        public User DeleteUser(int id)
        {
            var delUser = _context.Users.Single(x => x.Id == id);
            _context.Users.Remove(delUser);
            _context.SaveChanges();

            return delUser;

        }


    }
}
