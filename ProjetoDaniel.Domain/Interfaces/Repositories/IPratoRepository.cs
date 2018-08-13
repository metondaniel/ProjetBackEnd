using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Repositories
{
    public interface IPratoRepository: IRepositoryBase<Prato>
    {
        List<Prato> GetByParam(string name,double preco);

        Prato GetById(Guid Id);
    }
}
