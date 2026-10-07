using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PersonalId { get; set; }

        public Guid HotelId { get; set; }
        [ForeignKey(nameof(HotelId))]
        public Hotel? Hotel { get; set; }

        public ICollection<Payroll> Payrolls { get; set; } = new List<Payroll>();
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
