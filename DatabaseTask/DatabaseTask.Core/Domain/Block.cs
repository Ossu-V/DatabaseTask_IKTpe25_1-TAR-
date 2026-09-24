using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Block
    {
        public int BlockId { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public int SecurtyLvl { get; set; }
    }
}
