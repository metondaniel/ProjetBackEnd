using ProjetoDaniel.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDanielApplication.Interfaces
{
    public interface IPratoAppService
    {
        List<PratoDto> GetPrato(PratoDto dtoRequest);

        PratoDto GetPratoById(Guid id);

        PratoDto SavePrato(PratoDto dtoRequest);

        void UpdatePrato(PratoDto dtoRequest);

        void DeletePrato(Guid PratoId);
    }
}
