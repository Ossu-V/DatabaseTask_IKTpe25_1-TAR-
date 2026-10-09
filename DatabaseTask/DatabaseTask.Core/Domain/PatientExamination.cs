using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class PatientExamination
    {
        public Guid Id { get; set; }
        public DateOnly ExaminationDate { get; set; }
        public string Result { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

        public Guid ExaminationId { get; set; }
        public Examinations Examination { get; set; }

    }
}
