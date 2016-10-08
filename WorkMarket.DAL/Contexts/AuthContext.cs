using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkMarket.DAL.Contexts
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext() 
            : base("AuthConnection")
        {

        }
    }
}
