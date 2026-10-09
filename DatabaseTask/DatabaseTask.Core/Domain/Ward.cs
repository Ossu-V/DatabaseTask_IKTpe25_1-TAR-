using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Ward
    {
        public Guid Id { get; set; }
        public int WardNr { get; set; }
        public int Floor { get; set; }
        public int BedŃr { get; set; }

        public Guid HospitalCareId { get; set; }
        public HospitalCare HospitalCare { get; set; }

    }
}
