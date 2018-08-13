using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Builder
{
    public class PratoBuilder
    {
        public Prato Instance = new Prato();
        public PratoBuilder()
        {
            Instance.Id = Guid.NewGuid();
        }

        public PratoBuilder WithId(Guid id)
        {
            Instance.Id = id;
            return this;
        }

        public PratoBuilder WithName(string name)
        {
            Instance.Nome = name;
            return this;
        }
        public PratoBuilder WithPreco(double preco)
        {
            Instance.Preco = preco;
            return this;
        }
        public PratoBuilder WithRestaurante(Restaurante restaurante)
        {
            Instance.Restaurante = restaurante;
            return this;
        }
    }
}
