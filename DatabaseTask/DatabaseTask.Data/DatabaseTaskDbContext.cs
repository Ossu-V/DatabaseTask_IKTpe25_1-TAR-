using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Prison> Prison { get; set; }
        public DbSet<Block> Block { get; set; }
        public DbSet<Chamber> Chamber { get; set; }
        public DbSet<Crime> Crime { get; set; }
        public DbSet<Guards> Guards { get; set; }
        public DbSet<Guests> Guests { get; set; }
        public DbSet<Prisoner> Prisoner { get; set; }
        public DbSet<Punishment> Punishment { get; set; }
        public DbSet<Shift> Shift { get; set; }
        public DbSet<VisitingHr> VisitingHr { get; set; }
    }
}
