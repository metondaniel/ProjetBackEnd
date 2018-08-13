using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Dto
{
    public class PratoDto
    {
        public Guid Id { get; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public RestauranteDto Prato { get; set; }
    }
}
