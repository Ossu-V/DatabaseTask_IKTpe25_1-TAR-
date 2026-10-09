using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Doctor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int EmployeeNr { get; set; }
        public int Tel { get; set; }
        public string Field { get; set; }

        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }

        public Guid VisitId { get; set; }
        public Visits Visit { get; set; }

        public Guid PrescribingMedicationId { get; set; }
        public PrescribingMedication PrescribingMedication { get; set; }

        public Guid ExaminationId { get; set; }
        public Examinations Examination { get; set; }

    }
}
