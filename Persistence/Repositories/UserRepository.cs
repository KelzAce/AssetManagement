using Dapper;
using Domain.Models;
using Persistence.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class UserRepository
    {
        private readonly IDbConnection _dapperContext;
        public UserRepository(DapperDbContext dapperDbContect)
        {
            _dapperContext = dapperDbContect.CreateConnection();
        }

        public async Task<User> AddUserAsync(User user)
        {
            var db = _dapperContext;

            var parameters = new DynamicParameters();
            parameters.Add("@FirstName", user.FirstName);
            parameters.Add("@LastName", user.LastName);
            parameters.Add("@Email", user.Email);
            parameters.Add("@Phone", user.Phone);
            parameters.Add("@NIN", user.NIN);
            parameters.Add("Password", user.PasswordHash);
            parameters.Add("@BusinessInformation", user.BusinessInformation);

            //parameters.Add("@CreatedAt", user.CreatedAt);

            var createdUser = await db.QuerySingleOrDefaultAsync<User>(
                "sp_UserSignUp",
                parameters,
                commandType: CommandType.StoredProcedure
                );
            return createdUser;

            //Write Stored Procedure Script to perform this action
        }

    }
}
