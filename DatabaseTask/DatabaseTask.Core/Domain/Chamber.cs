using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Chamber
    {
        public int ChamberId { get; set; }
        public int Number { get; set; }
        public int Floor { get; set; }
        public int Capacity { get; set; }
        public int PrisonerId { get; set; }
        public int BlockId { get; set; }
        public int ShiftId { get; set; }
    }
}
