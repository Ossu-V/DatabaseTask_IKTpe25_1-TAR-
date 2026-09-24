using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Prison
    {
        public int PrisonId { get; set; }
        public int Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
    }
}
