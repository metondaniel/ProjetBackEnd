﻿using AutoMapper;
using ProjetoDaniel.Dto;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDanielWebApi.Mappings.Profiles
{
    public class RestauranteProfile: Profile
    {
        public RestauranteProfile()
        {
            CreateMap<RestauranteDto, Restaurante>();
            CreateMap<Restaurante, RestauranteDto>();
        }
    }
}
