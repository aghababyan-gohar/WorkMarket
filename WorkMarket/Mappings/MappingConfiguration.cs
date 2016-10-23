using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkMarket.Mappings
{
    public static class MappingConfiguration
    {
        public static Action<IMapperConfigurationExpression> Configure = (cfg) =>
        {
            cfg.AddProfile<ViewModelDTOMappingProfile>();
        };
    }
}
