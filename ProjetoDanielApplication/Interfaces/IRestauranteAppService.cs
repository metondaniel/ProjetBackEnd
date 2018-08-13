using ProjetoDaniel.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Interfaces
{
    public interface IRestauranteAppService
    {
        List<RestauranteDto> GetRestaurante(RestauranteDto dtoRequest);

        RestauranteDto GetRestauranteById(Guid id);

        RestauranteDto SaveRestaurante(RestauranteDto dtoRequest);

        void UpdateRestaurante(RestauranteDto dtoRequest);

        void DeleteRestaurante(Guid RestauranteId);
    }
}
