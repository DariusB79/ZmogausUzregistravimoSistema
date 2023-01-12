using Microsoft.EntityFrameworkCore;
using ZmogausUzregistravimoSistema.Clases;

namespace ZmogausUzregistravimoSistema
{
    public class RegistrationDbContext : DbContext
    {

        
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }

        public DbSet<Place> Places { get; set; }


        public RegistrationDbContext(DbContextOptions<RegistrationDbContext> options) : base(options) { }

    }
        
}
