using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Repositories
{
    public interface IRestauranteRepository : IRepositoryBase<Restaurante>
    {
        List<Restaurante> GetByParam(string name);

        Restaurante GetById(Guid Id);
    }
}
