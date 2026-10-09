using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Medications
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ActiveIngredients { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

        public Guid PrescribingMedicationId { get; set; }
        public PrescribingMedication PrescribingMedication { get; set; }

    }
}
