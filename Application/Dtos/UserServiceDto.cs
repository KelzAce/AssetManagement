using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static Domain.Enums.DomainEnum;

namespace Application.Dtos
{
    public class RegisterUserDto
    {
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string NIN { get; set; }
        public required string Phone { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BusinessInformation BusinessInformation { get; set; }
    }

    public class RegisterUserResponseDto
    {
        public required string Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        //public DateTime CreatedAt { get; set; }
    }
}
