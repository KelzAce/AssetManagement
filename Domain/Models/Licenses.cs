using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Enums.DomainEnum;

namespace Domain.Models
{
    public class Licenses
    {
        public string Id { get; set; }
        public string LicenseType { get; set; }
        public string LicenseDoc { get; set; }
        public DateTime LicenseIssueDate { get; set; }
        public DateTime LicenseExpDate { get; set; }
        public LicenseStatus LicenseStatus { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set; } = DateTime.Now;
    }
}
