using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Enums.DomainEnum;

namespace Domain.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string? PaymentId {  get; set; }
        public int Amount { get; set; }
        public required string PaymentType { get; set; }
        public required string Contract { get; set; }
        public required string Ministry { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
