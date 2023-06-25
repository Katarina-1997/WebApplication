using System.Data.Entity;

namespace WebApp.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            //Reference name connection string from web.config file 
            : base("DefaultConnection")
        {
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}