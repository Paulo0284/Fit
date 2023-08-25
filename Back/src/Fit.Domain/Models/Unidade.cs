using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fit.Domain.Models
{
    public class Unidade
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption: DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(100)]
        public string? NomeUnidade { get; set; }
    }
}