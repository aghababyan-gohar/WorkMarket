using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkMarket.BL.DTOs.Auth;
using WorkMarket.DAL.Entities;

namespace WorkMarket.BL.Mappings
{
    public class DTOEntityMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<UserDTO, User>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter();
        }
    }
}
