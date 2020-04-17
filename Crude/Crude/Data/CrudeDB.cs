
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Crude.Models;

namespace Crude.Data
{
    public class CrudeDB:DbContext
    {


        public CrudeDB(DbContextOptions<CrudeDB> options) : base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Espacos> Espacos { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Opcoes> Opcoes { get; set; }
        public DbSet<Perguntas> Perguntas { get; set; }
        public DbSet<Questionario> Questionarios { get; set; }
        public DbSet<Resposta> Respostas { get; set; }
        public DbSet<Tipos> Tipos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tipos>()       // THIS IS FIRST
                .HasOne(u => u.Espaco).WithMany(u => u.ListaDeTipos).IsRequired().OnDelete(DeleteBehavior.Restrict);

            // aqui vamos adicionar a nossa primeira cidade

            // aqui vamos adicionar a nossa primeira cidade

            modelBuilder.Entity<Cidade>().HasData(
                new Cidade
                {
                    Id = 1,
                    Nome = "Tomar",
                    Latitude = 39.60,
                    Longitude = -8.40,
                    // ListaDeEspaco
                });
            modelBuilder.Entity<Espacos>().HasData(
              new Espacos
              {
                  Id = 1,
                  Classificacao = 5,
                  NomeOficial = "Café Acadêmico",
                  NomeConhecido = "Aka",
                  Latitude = 39.60,
                  Longitude = -8.40,
                    // ListaDeEspaco
                });
            //modelBuilder.Entity<Tipos>().HasData(
            //new Tipos
            //{
            //    Id = 1,
            //    Tipo = "Café",
            //    //EspacosFK = 2,
            //    // ListaDeEspaco
            //});
            modelBuilder.Entity<Questionario>().HasData(
             new Questionario
             {
                 Id = 1,
                 Nome = "Quen és tu?",


             }); ;
            modelBuilder.Entity<Perguntas>().HasData(
             new Perguntas
             {
                 Id = 1,
                 Texto = "Olá Mundo!!! Quem és tu?"
                
              });
            // depois fazer add-migration seedCidade -contex AppDB
            // de seguida update database 
        }
    }
}
