using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Week5.Models;

namespace Week5.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Week5.Models.Restaurant>? Restaurant { get; set; }
        public DbSet<Week5.Models.Province>? Province { get; set; }
    }
}