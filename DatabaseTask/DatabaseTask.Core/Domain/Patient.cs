using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Patient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int PersonalCode { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int Tel { get; set; }
        public string Email { get; set; }

        public Guid VisitId { get; set; }
        public Visits Visit { get; set; }

        public Guid HospitalCareId { get; set; }
        public HospitalCare HospitalCare { get; set; }

        public Guid MedicationId { get; set; }
        public Medications Medication { get; set; }

    }
}
