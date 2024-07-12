using Microsoft.EntityFrameworkCore;

namespace EasySplit.ES.Repositories.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
