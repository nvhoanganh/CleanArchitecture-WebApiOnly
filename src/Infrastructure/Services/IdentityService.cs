using System.Linq;
using System.Threading.Tasks;
using Northwind.Application.Common.Interfaces;
using Northwind.Application.Common.Models;

namespace Northwind.Infrastructure.Services
{
    public class IdentityService : IIdentityService
    {
        public Task<bool> AuthorizeAsync(string userId, string policyName)
        {
            throw new System.NotImplementedException();
        }

        public Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password)
        {
            throw new System.NotImplementedException();
        }

        public Task<Result> DeleteUserAsync(string userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetUserNameAsync(string userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsInRoleAsync(string userId, string role)
        {
            throw new System.NotImplementedException();
        }
    }
}
