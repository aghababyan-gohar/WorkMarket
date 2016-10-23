using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkMarket.BL.DTOs.Auth;
using WorkMarket.ViewModels;

namespace WorkMarket.Mappings
{
    public class ViewModelDTOMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<UserViewModel, UserDTO>();
            CreateMap<UserDTO, UserViewModel>();
        }
    }
}
