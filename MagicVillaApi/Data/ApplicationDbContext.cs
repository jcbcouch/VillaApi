using MagicVillaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVillaApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
    }
}
