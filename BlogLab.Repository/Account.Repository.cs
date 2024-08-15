using Dapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using MiniProject.Models.Account;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly IConfiguration _config;

        public AccountRepository(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IdentityResult> CreateAsync(ApplicationUserIdentity user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();


            /* Creating virtual table taht represent the type */

            var dataTable = new DataTable();
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("NormalizedUsername", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("NormalizedEmail", typeof(string));
            dataTable.Columns.Add("Fullname", typeof(string));
            dataTable.Columns.Add("PasswordHash", typeof(string));

            dataTable.Rows.Add(
                user.Username,
                user.NormalizedUsername,
                user.Email,
                user.NormalizedEmail,
                user.Fullname,
                user.PasswordHash
                );

            // and when we have a type we are going to open up a connection with SQL server

            using (var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                //cancel it whenever we have an issue with ASP.NET Core identity.
                await connection.OpenAsync(cancellationToken);

                //Execute SP name "Account_Insert" 
                object value = await connection.ExecuteAsync("Account_Insert",
                    new { Account = dataTable.AsTableValuedParameter("dbo.AccountType") }, commandType: CommandType.StoredProcedure);
            }

            return IdentityResult.Success;
        }

        public async Task<ApplicationUserIdentity> GetByUsernameAsync(string normalizedUsername, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            ApplicationUserIdentity applicationUser;

            using (var connection = new SqlConnection(_config.GetConnectionString("DefaultConnection")))
            {
                await connection.OpenAsync(cancellationToken);

                applicationUser = await connection.QuerySingleOrDefaultAsync<ApplicationUserIdentity>(
                    "Account_GetByUsername", new { NormalizedUsername = normalizedUsername },
                    commandType: CommandType.StoredProcedure
                    );
            }

            return applicationUser;
        }
    }
}
