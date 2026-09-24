using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Guards
    {
        public int GuardsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}

