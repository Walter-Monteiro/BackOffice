using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crude.Models
{
    public class Espacos
    {
        public Espacos()
        {
            ListaDeTipos = new HashSet<Tipos>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public double Classificacao { get; set; }
        [Required]
        public string NomeOficial { get; set; }
        [Required]
        public string NomeConhecido { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }

        //lista dos tipo 
        public virtual ICollection<Tipos> ListaDeTipos { get; set; }

    }
}