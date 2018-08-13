using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Interfaces.Services
{
    public interface IPratoService: IServiceBase<Prato>
    {
        List<Prato> GetByParam(Prato prato);

        Prato GetById(Guid Id);
    }
}
