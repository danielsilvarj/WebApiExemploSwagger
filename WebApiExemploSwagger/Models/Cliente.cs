using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiExemploSwagger.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [MaxLength(50, ErrorMessage = "O campo nome suporta {1} caracteres")]
        public string Nome { get; set; }
        [MaxLength(100, ErrorMessage = "O campo Email suporta {1} caracteres")]
        public string Email { get; set; }
        public bool Ativo { get; set; }
    }
}
