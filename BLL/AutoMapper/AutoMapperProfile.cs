using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using DAL.Entities;

namespace BLL.AutoMapper
{
    class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ComputerDTO, Computer>().ReverseMap();
            CreateMap<ComputerPartsDTO, ComputerParts>().ReverseMap();
            CreateMap<OrderDTO, Order>().ReverseMap();
            CreateMap<OwnerDTO, Owner>().ReverseMap();
            CreateMap<PartDTO, Part>().ReverseMap();
            CreateMap<UserRegistrationModel, User>()
                .ForMember(u => u.UserName,
                    opt => opt.MapFrom(x => x.Email));
        }
    }
}
