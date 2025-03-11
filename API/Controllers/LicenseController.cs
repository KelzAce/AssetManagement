using Application.Dtos;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/license")]
    [ApiController]
    public class LicenseController : ControllerBase
    {
        private readonly LicenseService _licenseService;
        public LicenseController(LicenseService licenseService)
        {
            _licenseService = licenseService;
        }

        [HttpPost("CreateLicense")]
        public async Task<IActionResult> CreateLicense([FromBody] LicenseServiceDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            var resp = await _licenseService.AddLicenseAsync(dto);
            return Ok(resp);
        }

        [HttpGet("getLicense")]
        public async Task<IActionResult> GetLicense()
        {
            var resp = await _licenseService.GetLicenseAsync();
            return Ok(resp);
        }
    }
}
