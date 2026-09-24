using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Guests
    {
        public int GuestsId { get; set; }
        public int PersonalId { get; set; }
        public int Phonenumber { get; set; }
        public string Relationship { get; set; }
    }
}
