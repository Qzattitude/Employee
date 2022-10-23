using Microsoft.EntityFrameworkCore;
using Employee.Models;

namespace Employee.Controllers.DB_Controller
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        public DbSet<Employees> Employees { get; set; }
    }
}
