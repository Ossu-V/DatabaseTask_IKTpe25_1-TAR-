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
        public DbSet<Patient> Departments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Visits> Visits { get; set; }
        public DbSet<Examinations> Examinations { get; set; }
        public DbSet<PatientExamination> PatientExaminations { get; set; }
        public DbSet<PrescribingMedication> PrescribingMedications { get; set; }
        public DbSet<Medications> Medications { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<HospitalCare> HospitalCares { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
