using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Enums.DomainEnum;

namespace Domain.Models
{
    public class Asset
    {
        public string Id { get; set; } //Change to Guid
        public string AssetName { get; set; }
        public string Contract {  get; set; }
        public string Address { get; set; }
        public string Quantity {get; set; }
        public string ContractType { get; set; }
        public StatusReport StatusReport { get; set; } = StatusReport.Assigned;
        public DateTime DateUploaded { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
