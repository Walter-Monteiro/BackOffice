using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crude.Models
{
    public class Nota
    {
        [Key]
        public int Id { get; set; }
        public double Avaliacao { get; set; }
    }
}