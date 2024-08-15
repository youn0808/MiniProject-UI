using Microsoft.AspNetCore.Identity;
using MiniProject.Models.Account;

namespace BlogLab.Repository
{
    public interface IAccountRepository
    {
        public Task<IdentityResult> CreateAsync(ApplicationUserIdentity user,
            CancellationToken cancellationToken);
        /*ASP.Core Ideneity is going to give us if for whatever reason they cancel their process,
         * then this "CancellationToken object will pass down to us so that we can cancel our operation*/

        public Task<ApplicationUserIdentity> GetByUsernameAsync(string normalizedUsername,
            CancellationToken cancellationToken);
    }
}
