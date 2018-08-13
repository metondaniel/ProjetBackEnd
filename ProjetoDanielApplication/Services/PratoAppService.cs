using AutoMapper;
using ProjetoDaniel.Domain.Builder;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Dto;
using ProjetoDaniel.Model;
using ProjetoDanielApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Services
{
    public class PratoAppService : IPratoAppService
    {
        private readonly IPratoService _service;
        private readonly IMapper _mapper;
        public PratoAppService(IPratoService pratoService, IMapper mapper)
        {
            _service = pratoService;
            _mapper = mapper;
        }

        public void DeletePrato(Guid PratoId)
        {
            _service.Delete(_service.GetById(PratoId));
        }

        public List<PratoDto> GetPrato(PratoDto dtoRequest)
        {
            return _mapper.Map<List<PratoDto>>(_service.GetByParam(
                _mapper.Map<Prato>(dtoRequest)));
        }

        public PratoDto GetPratoById(Guid id)
        {
            return _mapper.Map<PratoDto>(_service.GetById(id));
        }

        public PratoDto SavePrato(PratoDto dtoRequest)
        {
            var pratoBuilder = new PratoBuilder()
                .WithName(dtoRequest.Nome)
                .WithPreco(dtoRequest.Preco);
            return _mapper.Map<PratoDto>(_service.Add(pratoBuilder.Instance));
        }

        public void UpdatePrato(PratoDto dtoRequest)
        {
            var pratoBuilder = new PratoBuilder()
                .WithId(dtoRequest.Id)
                .WithName(dtoRequest.Nome)
                .WithPreco(dtoRequest.Preco);
            _service.Update(pratoBuilder.Instance);
        }
    }
}
