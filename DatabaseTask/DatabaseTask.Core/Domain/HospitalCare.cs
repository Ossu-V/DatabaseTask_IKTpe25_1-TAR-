using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class HospitalCare
    {
        public Guid Id { get; set; }
        public DateOnly ArrivalDate { get; set; }
        public DateOnly DepartureDate { get; set; }
        public string Reason { get; set; }

        public Guid PatientId { get; set; }
        public Patient Patient { get; set; }

        public Guid WardId { get; set; }
        public Ward Ward { get; set; }


    }
}
