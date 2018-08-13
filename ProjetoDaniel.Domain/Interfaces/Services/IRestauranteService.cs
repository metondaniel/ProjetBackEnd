using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Services
{
    public interface IRestauranteService: IServiceBase<Restaurante>
    {
        List<Restaurante> GetByParam(Restaurante prato);
        Restaurante GetById(Guid Id);
    }
}
