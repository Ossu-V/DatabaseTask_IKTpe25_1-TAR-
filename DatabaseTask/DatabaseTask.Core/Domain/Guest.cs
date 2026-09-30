using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Guest
    {
        public int GuestId { get; set; }
        public int PersonalId { get; set; }
        public int Phonenumber { get; set; }
        public string Relationship { get; set; }
        public string PrisonerId { get; set; }
    }
}
