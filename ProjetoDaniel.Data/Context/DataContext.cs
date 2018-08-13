using Microsoft.EntityFrameworkCore;
using ProjetoDaniel.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDaniel.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Prato> Pratos { get; set; }

        public DbSet<Restaurante> Restaurantes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Prato>()
            .HasKey(pr => new { pr.Id });

            builder.Entity<Restaurante>()
            .HasKey(re => new { re.Id });

            builder.Entity<Prato>()
               .HasOne(re => re.Restaurante);


        }

    }
    }
