using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class LicenseServiceDto
    {
        public  required string LicenseType { get; set; }
        public required string LicenseDoc {  get; set; }
        public required DateTime LicenseIssueDate { get; set; }
        public required DateTime LicenseExpDate { get; set; }
        public required string LicenseStatus { get; set; }
    }

    public class LicenseServiceResponseDto
    {
        public required string LicenseType { get; set; }
        public required string LicenseDoc { get; set; }
        public required DateTime LicenseIssueDate { get; set; }
        public required DateTime LicenseExpDate { get; set; }
        public required string LicenseStatus { get; set; }
    }
}
