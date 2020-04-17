using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crude.Models
{
    public class Questionario
    {
        public Questionario()
        {
            ListaDePerguntas = new HashSet<Perguntas>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }

        // **************************
        // criar a chave forasteira
        // relaciona o objeto Questionario com um objeto Aluno
        public Questionario Questionarios { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("Questionario")]
        public int QuestionarioFK { get; set; }
        // **************************

        // um Questionario tem várias perguntas
        public virtual ICollection<Perguntas> ListaDePerguntas { get; set; }
    }
}