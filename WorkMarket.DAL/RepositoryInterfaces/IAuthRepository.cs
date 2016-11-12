using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkMarket.DAL.Entities;

namespace WorkMarket.DAL.RepositoryInterfaces
{
    public interface IAuthRepository
    {
        Task<IdentityResult> RegisterUser(User userModel);
        Task<IdentityUser> FindUser(string userName, string password);
        void Dispose();

    }
}
