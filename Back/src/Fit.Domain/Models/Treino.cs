using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fit.Domain.Models
{
    public class Treino
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Observacoes { get; set; }
        public DateTime Inicio {get; set;}
        public int AlunoId {get;set;}
        public Aluno? Aluno { get; set; }
        public IEnumerable<TreinoExercicio>? TreinoExercicios { get; set; }

    }
}