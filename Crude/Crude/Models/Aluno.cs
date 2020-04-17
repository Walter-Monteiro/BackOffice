using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crude.Models
{
    public class Aluno
    {
        public Aluno()
        {
            ListaDeQuestionarios = new HashSet<Questionario>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public DateTime DataNascimento { get; set; }
        [Required]
        public double Peso { get; set; }
        [Required]
        public string Sexo { get; set; }

        // Um  Aluno  pode preencher 1 ou mais Questionários
        public ICollection<Questionario> ListaDeQuestionarios { get; set; }

    }

}