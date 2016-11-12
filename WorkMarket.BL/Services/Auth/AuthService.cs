using Microsoft.AspNet.Identity;
using System;
using System.Threading.Tasks;
using WorkMarket.BL.DTOs.Auth;
using WorkMarket.DAL.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using WorkMarket.BL.Mappings;
using WorkMarket.BL.ServiceContracts.Auth;
using WorkMarket.DAL.RepositoryInterfaces;

namespace WorkMarket.BL.Services.Auth
{

    public class AuthService : IAuthService, IDisposable //TODO: check if this is a good practice
    {
        private IAuthRepository _repository;

        public AuthService(IAuthRepository repository)
        {
            _repository = repository;
        }

        public async Task<IdentityResult> RegisterUser(UserDTO userModel)
        {
            var user = userModel.MapTo<User>();
            IdentityResult result = await _repository.RegisterUser(user);

            return result;
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public Task<IdentityUser> FindUser(string userName, string password)
        {
            return _repository.FindUser(userName, password);
        }
    }
}
