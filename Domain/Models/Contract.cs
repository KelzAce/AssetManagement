using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Enums.DomainEnum;

namespace Domain.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public required string ContractId { get; set; }
        public required string ContractName { get; set; }
        public required string Ministry { get; set; }
        public required string Payment { get; set; }
        public required string Document { get; set; }
        public ContractStatus Status  { get; set; }
        public DateTime DateApproved { get; set; }
    }
}
