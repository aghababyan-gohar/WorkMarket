using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkMarket.DAL.Repositories;
using WorkMarket.DAL.RepositoryInterfaces;

namespace WorkMarket.DI.Registration
{
    public class DALModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AuthRepository>().As<IAuthRepository>();

            base.Load(builder);
        }
    }
}
