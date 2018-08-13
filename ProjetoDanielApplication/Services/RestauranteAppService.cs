using AutoMapper;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Dto;
using ProjetoDaniel.Model;
using ProjetoDanielApplication.Interfaces;
using ProjetoDaniel.Domain.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Services
{
    public class RestauranteAppService : IRestauranteAppService
    {
        private readonly IRestauranteService _service;
        private readonly IMapper _mapper;
        public RestauranteAppService(IRestauranteService RestauranteService, IMapper mapper)
        {
            _service = RestauranteService;
            _mapper = mapper;
        }

        public void DeleteRestaurante(Guid RestauranteId)
        {
            _service.Delete(_service.GetById(RestauranteId));
        }

        public List<RestauranteDto> GetRestaurante(RestauranteDto dtoRequest)
        {
            return _mapper.Map<List<RestauranteDto>>(_service.GetByParam(
                _mapper.Map<Restaurante>(dtoRequest)));
        }

        public RestauranteDto GetRestauranteById(Guid id)
        {
            return _mapper.Map<RestauranteDto>(_service.GetById(id));
        }

        public RestauranteDto SaveRestaurante(RestauranteDto dtoRequest)
        {
            var RestauranteBuilder = new RestauranteBuilder()
                .WithName(dtoRequest.Nome);
            return _mapper.Map<RestauranteDto>(_service.Add(RestauranteBuilder.Instance));
        }

        public void UpdateRestaurante(RestauranteDto dtoRequest)
        {
            var RestauranteBuilder = new RestauranteBuilder()
                .WithId(dtoRequest.Id)
                .WithName(dtoRequest.Nome);
            _service.Update(RestauranteBuilder.Instance);
        }
    }
}
