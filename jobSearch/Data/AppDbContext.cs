using jobSearch.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace jobSearch.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Firm> Firms { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Vacancy> Vacancy { get; set; }
    }
}
