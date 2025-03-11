using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domain.Enums.DomainEnum;

namespace Domain.Models
{
    public class User
    {
        public string Id { get; set; } //Later change to Guid
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public string? Phone { get; set; }
        public string? NIN { get; set; }
        public BusinessInformation? BusinessInformation { get; set; }
        public  string? PasswordHash { get; set; }
        //public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        //public DateTime? LastUpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
