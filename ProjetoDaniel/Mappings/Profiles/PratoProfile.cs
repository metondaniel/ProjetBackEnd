using AutoMapper;
using ProjetoDaniel.Dto;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDanielWebApi.Mappings.Profiles
{
    public class PratoProfile : Profile
    {
        public PratoProfile()
        {
            CreateMap<PratoDto, Prato>();
            CreateMap<Prato, PratoDto>();
        }
    }
}
