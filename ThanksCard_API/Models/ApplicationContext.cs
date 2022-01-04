using Microsoft.EntityFrameworkCore;
namespace ThanksCard_API.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ThanksCard> ThanksCards { get; set; }
        public DbSet<ThanksCard_API.Models.Tag> Tag { get; set; }
    }
}
