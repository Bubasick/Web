using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BLL.DTO;
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

        }
    }
}
