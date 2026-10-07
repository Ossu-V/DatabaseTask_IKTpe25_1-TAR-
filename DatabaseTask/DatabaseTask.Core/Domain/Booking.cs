using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Booking
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public int PeopleCount { get; set; }
        public string PaymentMethod { get; set; }
        public int RoomAmount { get; set; }
        public double Cost { get; set; }

        public Guid EmployeeId { get; set; }
        [ForeignKey(nameof(EmployeeId))]
        public Employee? Employee { get; set; }

        public Guid GuestsId { get; set; }
        [ForeignKey(nameof(GuestsId))]
        public Guests? Guest { get; set; }

        public ICollection<Bookable> Bookables { get; set; } = new List<Bookable>();
        public ICollection<ServiceOrder> ServiceOrders { get; set; } = new List<ServiceOrder>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
