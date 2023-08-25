using Fit.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Fit.Persistence.Contextos;

public class FitContext : DbContext
{
    public FitContext(DbContextOptions<FitContext> options) : base(options)
    {
        
    }
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Exercicio> Exercicios { get; set; }
    public DbSet<GrupoMuscular> GruposMusculares { get; set; }
    public DbSet<Treino> Treinos { get; set; }
    public DbSet<TreinoExercicio> TreinoExercicios { get; set; }
    public DbSet<Unidade> Unidades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<TreinoExercicio>()
            .HasKey(TE => new { TE.TreinoId, TE.ExercicioId });
    }

}