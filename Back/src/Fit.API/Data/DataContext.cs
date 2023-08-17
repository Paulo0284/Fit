using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fit.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Fit.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Aluno> Alunos { get; set; }
    }
}