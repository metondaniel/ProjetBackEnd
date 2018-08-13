using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDaniel.Model
{
    public class Prato
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }

        public Restaurante Restaurante { get; set; }
        
    }
}
