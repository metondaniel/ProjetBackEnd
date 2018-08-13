using ProjetoDaniel.Data.Context;
using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoDaniel.Data.Repository
{
    public class RestauranteRepository : RepositoryBase<Restaurante>, IRestauranteRepository
    {
        public RestauranteRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public Restaurante GetById(Guid Id)
        {
            var prato = Db.Set<Restaurante>().FirstOrDefault(x => x.Id == Id);
            return prato;
        }

        public List<Restaurante> GetByParam(string name)
        {
            var prato = Db.Set<Restaurante>().Where(x => !string.IsNullOrEmpty(name) ? x.Nome == name : true);
            return prato.ToList();
        }
    }
}
