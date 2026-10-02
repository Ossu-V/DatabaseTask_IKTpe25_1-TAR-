using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Core.Domain
{
    public class Payment
    {
        [Key]
        public Guid Id { get; set; }
        public float PaymentDate { get; set; }
        public float Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}

