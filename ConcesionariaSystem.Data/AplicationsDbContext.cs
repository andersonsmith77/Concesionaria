using ConcesionariaSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcesionariaSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Autos> Autos { get; set; }
    }
}
