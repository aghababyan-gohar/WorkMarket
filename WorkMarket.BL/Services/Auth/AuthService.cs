using Microsoft.AspNet.Identity;
using System;
using System.Threading.Tasks;
using WorkMarket.BL.DTOs.Auth;
using WorkMarket.DAL.Entities;
using WorkMarket.DAL.Repositories.Auth;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WorkMarket.BL.Services.Auth
{

    public class AuthService : IDisposable //TDOD: check if this is a good practice
    {
        private AuthRepository _repository;

        public AuthService()
        {
            _repository = new AuthRepository();
        }

        public async Task<IdentityResult> RegisterUser(UserDTO userModel)
        {
            //TODO: add autommaper mapping here
            var user = new User
            {
                UserName = userModel.UserName,
                Password = userModel.Password
            };
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
