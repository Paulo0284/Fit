using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fit.Domain.Models
{
    public class Exercicio
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(200)]
        public string? NomeExercicio { get; set; }
        public int GrupoMuscularId { get; set; }
        public GrupoMuscular? GrupoMuscular {get; set;}
        public string? URL { get; set; }
    }
}