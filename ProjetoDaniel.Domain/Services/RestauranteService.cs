using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Services
{
    public class RestauranteService : ServiceBase<Restaurante>, IRestauranteService
    {
        private readonly IRestauranteRepository _restauranteRepository;
        public RestauranteService(IRestauranteRepository restauranteRepository) : base(restauranteRepository)
        {
            _restauranteRepository = restauranteRepository;
        }
        public List<Restaurante> GetByParam(Restaurante restaurante)
        {
            if (restaurante == null)
                restaurante = new Restaurante();
            return _restauranteRepository.GetByParam(restaurante.Nome);
        }
        public Restaurante GetById(Guid Id)
        {
            return _restauranteRepository.GetById(Id);
        }
    }
}
