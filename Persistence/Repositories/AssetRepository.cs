using Dapper;
using Domain.Models;
using Persistence.DAO;
using Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shared.Dtos.SharedAssetDto;

namespace Persistence.Repositories
{
    public class AssetRepository
    {
        private readonly IDbConnection _dapperContext;
        public AssetRepository(DapperDbContext dapperDbContext)
        {
            _dapperContext = dapperDbContext.CreateConnection();
        }

        public async Task<CreateAssetResponseDto> AddAssetAsync(CreateAssetDto createAssetDto)
        {
            var db = _dapperContext;

            var parameters = new DynamicParameters();
            parameters.Add("@Project", createAssetDto.Project);
            parameters.Add("@ProjectType", createAssetDto.ProjectType);
            parameters.Add("@Ministry", createAssetDto.Ministry);
            parameters.Add("@Doc", createAssetDto.Doc);
         

            var newAsset = await db.QuerySingleOrDefaultAsync<CreateAssetResponseDto>(
                "sp_AddNewAsset",
                parameters,
                commandType: CommandType.StoredProcedure
                );
            return newAsset!;
        }

        public async Task<GetAssetResponseDto> GetAllAssetsAsync()
        {
            var db = _dapperContext;
         

            var result = await db.QueryFirstOrDefaultAsync<GetAssetResponseDto>(
                "spGetAsset",
                commandType: CommandType.StoredProcedure
                );
            return result!;
        }
    }
}
