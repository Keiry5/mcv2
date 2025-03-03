using mcv2.Models;
using Microsoft.EntityFrameworkCore;

namespace mcv2.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options) 
        {

        }
        public DbSet<Alumnos> Alumnos { get; set; }

    }
}
