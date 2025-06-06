using JWT_Auth.Controllers;
using JWT_Auth.Model;
using Microsoft.EntityFrameworkCore;

namespace JWT_Auth.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base (options) { }

        public DbSet<User> Users { get; set; }
    }
}
