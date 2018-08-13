using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Domain.Builder
{
    public class RestauranteBuilder
    {
        public Restaurante Instance = new Restaurante();
        public RestauranteBuilder()
        {
            Instance.Id = Guid.NewGuid();
        }

        public RestauranteBuilder WithId(Guid id)
        {
            Instance.Id = id;
            return this;
        }

        public RestauranteBuilder WithName(string name)
        {
            Instance.Nome = name;
            return this;
        }
       
    }
}
