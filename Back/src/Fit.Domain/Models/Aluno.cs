using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Fit.Domain.Models
{
    [Index(nameof(Cpf), IsUnique = true)]
    [Index(nameof(Email), IsUnique = true)]
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(200)]
        public string? NomeAluno { get;set;} 
        [Column(TypeName = "Date")]
        public DateTime DataNascimento { get; set; }
        [Required]
        public long Cpf { get; set; }
        [StringLength(3)]
        public string? TipoSanguineo { get; set; }
        public int Altura { get; set; }
        public DateTime DataCadastro { get; set; }
        public string? FotoAluno {get; set; }
        [StringLength(11)]
        public string? Telefone {get; set;}
        [StringLength(100)]
        public string? Email { get; set; }
        public IEnumerable<Treino>? Treinos {get; set;}

    }
}