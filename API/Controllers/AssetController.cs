using Application.Dtos;
using Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;
using static Shared.Dtos.SharedAssetDto;

namespace API.Controllers
{
    [Route("api/asset")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly AssetService _assetService;
        public AssetController(AssetService assetService)
        {
            _assetService = assetService;
        }

        [HttpPost("UploadAsset")]
        public async Task<IActionResult> UploadAsset([FromBody] CreateAssetDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }
            var resp = await _assetService.AddAssetAsync(dto);
            return Ok(resp);
        }

        [HttpGet("GetAsset")]
        public async Task<IActionResult> GetAsset()
        {
            var resp = await _assetService.GetAssetAsync();
            return Ok(resp);
        }
    }
}
