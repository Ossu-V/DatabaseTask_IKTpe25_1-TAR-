using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    internal class Shift
    {
        public int ShiftId { get; set; }
        public int GuardsId { get; set; }
        public DateOnly StarDate { get; set; }
        public DateOnly EndDate { get; set; }

    }
}
