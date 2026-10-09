using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Examinations
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public Guid PatientExaminationId { get; set; }
        public PatientExamination PatientExamination { get; set; }

    }
}

