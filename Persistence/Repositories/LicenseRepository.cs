using Dapper;
using Domain.Models;
using Persistence.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class LicenseRepository
    {
        private readonly IDbConnection _dapperContext;
        public LicenseRepository(DapperDbContext dapperDbContect)
        {
            _dapperContext = dapperDbContect.CreateConnection();
        }

        public async Task<Licenses> AddLicenseAsync(Licenses license)
        {
            var db = _dapperContext;

            var parameters = new DynamicParameters();
            parameters.Add("@LicenseType", license.LicenseType);
            parameters.Add("@LicenseDoc", license.LicenseDoc);
            parameters.Add("@LicenseIssueDate", license.LicenseIssueDate);
            parameters.Add("@LicenseExpDate", license.LicenseExpDate);
            parameters.Add("@LicenseStatus", license.LicenseStatus);
            parameters.Add("@CreatedAt", license.CreatedAt);
            parameters.Add("@LastUpdatedAt", license.LastUpdatedAt);

            var createdLicense = await db.QuerySingleOrDefaultAsync<Licenses>(
                "sp_CreateLicense",
                parameters,
                commandType: CommandType.StoredProcedure
                );
            return createdLicense;
        }

        public async Task<Licenses> GetLicenseListAsync()
        {
            var db = _dapperContext;

            var parameters = new DynamicParameters();
            //parameters.Add("@LicenseType", license.LicenseType);
        

            var fetchedLicense = await db.QuerySingleOrDefaultAsync<Licenses>(
               "sp_GetLicense",
               parameters,
               commandType: CommandType.StoredProcedure
               );
            return fetchedLicense;
        }
    }
}
