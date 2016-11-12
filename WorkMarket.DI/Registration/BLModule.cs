using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkMarket.BL.ServiceContracts.Auth;
using WorkMarket.BL.Services.Auth;

namespace WorkMarket.DI.Registration
{
    public class BLModule : DALModule
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthService>().As<IAuthService>()
                .PropertiesAutowired();

            base.Load(builder);
        }
    }
}
