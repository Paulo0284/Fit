using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fit.Domain.Models
{
    public class TreinoExercicio
    {
        [Key]
        [Column(Order = 0)]
        public int TreinoId { get; set; }
        public Treino? Treino { get; set; }
        [Key]
        [Column(Order = 1)]
        public int ExercicioId { get; set; }
        public Exercicio? Exercicio { get; set; }  
        public int UnidadeId { get; set; }
        public Unidade? Unidade { get; set; }
        public int DiaDaSemana { get; set; }
        public int Valor { get; set; }
        public int Series { get; set; }
        public int Repeticoes { get; set; }

    }
}