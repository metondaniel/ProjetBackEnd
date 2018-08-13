using ProjetoDaniel.Data.Context;
using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoDaniel.Data.Repository
{
    public class PratoRepository : RepositoryBase<Prato>, IPratoRepository
    {
        private readonly DataContext context;
        public PratoRepository(DataContext dataContext) : base(dataContext)
        {
            context = dataContext;
        }

        public Prato GetById(Guid Id)
        {
            var prato = Db.Set<Prato>().FirstOrDefault(x => x.Id == Id);
            return prato;
        }

        public List<Prato> GetByParam(string nome,double preco)
        {
            var prato = Db.Set<Prato>().Where(x => !string.IsNullOrEmpty(nome) ? x.Nome  == nome: true && preco != 0 ? x.Preco == preco : true);
            return prato.ToList();
        }
    }
}
