using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crude.Models
{
    public class Opcoes
    {
        [Key]
        public int Id { get; set; }
        public string Opcao { get; set; }
    }
}