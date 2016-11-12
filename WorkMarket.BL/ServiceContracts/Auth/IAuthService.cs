using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WorkMarket.BL.DTOs.Auth;

namespace WorkMarket.BL.ServiceContracts.Auth
{
    public interface IAuthService
    {
        void Dispose();
        Task<IdentityUser> FindUser(string userName, string password);
        Task<IdentityResult> RegisterUser(UserDTO userModel);
    }
}