using ProjetoDaniel.Domain.Interfaces.Repositories;
using ProjetoDaniel.Domain.Interfaces.Services;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Services
{
    public class PratoService : ServiceBase<Prato>, IPratoService
    {
        private readonly IPratoRepository _pratoRepository;
        public PratoService(IPratoRepository pratoRepository): base(pratoRepository)
        {
            _pratoRepository = pratoRepository;
        }

        public List<Prato> GetByParam(Prato prato)
        {
            if (prato == null)
            {
                prato = new Prato();
            }
            return _pratoRepository.GetByParam(prato.Nome,prato.Preco);
        }

        public Prato GetById(Guid id)
        {
            return _pratoRepository.GetById(id);
        }
    }
}
