using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.DAO
{
    public class DapperDbContext
    {
        private readonly string _connectionString;

        public DapperDbContext(IConfiguration configuration) 
            {
         _connectionString = configuration.GetConnectionString("DefaultSQLConnection")
         ?? throw new ArgumentNullException("Connection string not found");
        }

            public IDbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
