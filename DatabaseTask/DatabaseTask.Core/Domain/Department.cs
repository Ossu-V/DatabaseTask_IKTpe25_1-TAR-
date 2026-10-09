using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Floor { get; set; }
        public int Tel { get; set; }
    }
}
