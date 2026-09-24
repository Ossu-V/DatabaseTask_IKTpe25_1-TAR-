using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Prisoner
    {
        public int PrisonerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public int PersonalId { get; set; }
        public DateOnly ArrivalDate { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public string Status { get; set; }
    }
}
