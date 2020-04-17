using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crude.Models
{
    public class Perguntas
    {
        public Perguntas()
        {
            ListaDeRespostas = new HashSet<Resposta>();
        }
        [Key]
        public int Id { get; set; }
        public string Texto { get; set; }

        // uma Pergunta tem várias respostas
        public virtual ICollection<Resposta> ListaDeRespostas { get; set; }
    }
}