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
        public required string AssetName { get; set; }
        public required string Project {  get; set; }
        public required string ProjectType { get; set; }
        public required string Ministry { get; set; }
        public required string Doc { get; set; }
        public DateTime DateUploaded { get; set; }
        public required string AssetStatus { get; set; } 
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
