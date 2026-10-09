using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PrescribingMedication
    {
        public Guid Id { get; set; }
        public int Dose { get; set; }
        public int DoseFrequency { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        public Guid DoctorId { get; set; }
        public Doctor Doctor { get; set; }

        public Guid MedicationId { get; set; }
        public Medications Medication { get; set; }

    }
}
