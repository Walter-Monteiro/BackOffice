
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
        }
    }
}
