using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crude.Models
{
    public class Cidade
    {// Classe que representa cada 'Cidade'

            // vai representar os dados da tabela das Cidades

            // criar o construtor desta classe
            // e carregar a lista de Espaços
            public Cidade()
            {
                ListaDeEspacos = new HashSet<Espacos>();
            }

            [Key]
            public int Id { get; set; }
            [Required]
            public string Nome { get; set; }
            [Required]
            public double Latitude { get; set; }
            [Required]
            public double Longitude { get; set; }

            // Uma Cidade  pode ter 1 ou mais Espaços de sinalização
            public ICollection<Espacos> ListaDeEspacos { get; set; }

        }
}