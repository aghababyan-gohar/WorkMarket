using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkMarket.DAL.Entities;

namespace WorkMarket.DAL.Contexts
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext() 
            : base("AuthConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>().ToTable("User");

            base.OnModelCreating(modelBuilder);            
        }
    }
}
