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
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Visits> Visits { get; set; }
        public DbSet<Examinations> Examinations { get; set; }
        public DbSet<PatientExamination> PatientExaminations { get; set; }
        public DbSet<PrescribingMedication> PrescribingMedications { get; set; }
        public DbSet<Medications> Medications { get; set; }
        public DbSet<Ward> Wards { get; set; }
        public DbSet<HospitalCare> HospitalCares { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Doctor)
                .WithOne(doc => doc.Department)
                .HasForeignKey<Department>(d => d.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Doctor>()
                .HasOne(d => d.Visit)
                .WithOne(v => v.Doctor)
                .HasForeignKey<Doctor>(d => d.VisitId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Doctor>()
                .HasOne(d => d.PrescribingMedication)
                .WithOne(pm => pm.Doctor)
                .HasForeignKey<Doctor>(d => d.PrescribingMedicationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Doctor>()
                .HasOne(d => d.Examination)
                .WithOne(e => e.Doctor)
                .HasForeignKey<Doctor>(d => d.ExaminationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Visit)
                .WithOne(v => v.Patient)
                .HasForeignKey<Patient>(p => p.VisitId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.HospitalCare)
                .WithOne(hc => hc.Patient)
                .HasForeignKey<Patient>(p => p.HospitalCareId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Medication)
                .WithOne(m => m.Patient)
                .HasForeignKey<Patient>(p => p.MedicationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PrescribingMedication>()
                .HasOne(pm => pm.Medication)
                .WithOne(m => m.PrescribingMedication)
                .HasForeignKey<PrescribingMedication>(pm => pm.MedicationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PatientExamination>()
                .HasOne(pe => pe.Examination)
                .WithOne(e => e.PatientExamination)
                .HasForeignKey<PatientExamination>(pe => pe.ExaminationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<HospitalCare>()
                .HasOne(hc => hc.Ward)
                .WithOne(w => w.HospitalCare)
                .HasForeignKey<HospitalCare>(hc => hc.WardId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
