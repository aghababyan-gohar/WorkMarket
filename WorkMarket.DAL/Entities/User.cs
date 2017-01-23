using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkMarket.DAL.Entities
{
    public class User : IdentityUser
    {
        public string Password { get; set; }
    }
}
