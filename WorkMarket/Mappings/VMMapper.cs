using AutoMapper;
using AutoMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkMarket.Mappings
{
    public class VMMapper
    {
        public static IMapper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MapperConfiguration(MappingConfiguration.Configure)
                                   .CreateMapper();
                }
                return instance;
            }
        }
        private static IMapper instance;
    }
}
