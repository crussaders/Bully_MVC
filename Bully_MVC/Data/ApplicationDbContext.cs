using Bully_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Bully_MVC.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)  
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
