
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crude.Models
{
    public class Tipos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Tipo { get; set; }
        [ForeignKey(nameof(Espacos))]
        public int EspacosFK { get; set; }
        public Espacos Espaco { get; set; }
    }
}