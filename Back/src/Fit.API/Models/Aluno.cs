using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Fit.API.Models
{
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int IdAluno { get; set; }
        [StringLength(200)]
        public string? NomeAluno { get;set;} 
        [Column(TypeName = "Date")]
        public DateTime DataNascimento { get; set; }
        [StringLength(3)]
        public string? TipoSanguineo { get; set; }
        public int Altura { get; set; }
        public DateTime DataCadastro { get; set; }
        public string? FotoAluno {get; set; }


    }
}