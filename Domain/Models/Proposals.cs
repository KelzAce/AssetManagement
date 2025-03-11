using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Enums.DomainEnum;

namespace Domain.Models
{
    public class Proposals
    {
        public int Id { get; set; }
        public required string ProposalName { get; set; }
        public Contract Contract {  get; set; }
        public MinistryName Ministry {get; set; }
        public required string proposalDoc {get; set; }
        public ProposalStatus proposalStatus { get; set; }
        public DateTime DateSubmitted { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime DateUpdated { get; set; } = DateTime.Now;


    }
}
