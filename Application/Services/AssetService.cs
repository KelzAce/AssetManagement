using Application.Dtos;
using Application.Services.Interfaces;
using Domain.Models;
using Persistence.Repositories;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.Application.Services;
using static Shared.Dtos.SharedAssetDto;

namespace Application.Services
{
    public class AssetService
    {
        private readonly AssetRepository _assetRepository;
        public AssetService(AssetRepository assetRepository)
        {
            _assetRepository = assetRepository;
        }

        public async Task<IServiceResponse<CreateAssetResponseDto>> AddAssetAsync(CreateAssetDto createAssetDto)
        {
         var respDto = await _assetRepository.AddAssetAsync(createAssetDto);
            return new ServiceResponse<CreateAssetResponseDto>(
                "Asset record was added succesfully",
                true,
                respDto
                );
        }

        public async Task<IServiceResponse<GetAssetResponseDto>> GetAssetAsync()
        {
            var assets = await _assetRepository.GetAllAssetsAsync();

            if (assets == null)
            {
                throw new HttpRequestException("No assets found");
            }

            return new ServiceResponse<GetAssetResponseDto>(
                "Assets retrieved successfully",
                true,
                assets
            );
        }
    }
}
