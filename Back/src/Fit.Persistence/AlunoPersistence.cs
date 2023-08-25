using Fit.Domain.Models;
using Fit.Persistence.Contratos;
using Microsoft.EntityFrameworkCore;
using Fit.Persistence.Contextos;

namespace Fit.Persistence;

public class AlunoPersistence : IAlunoPersistence
{
    public FitContext _context { get; }
    public AlunoPersistence(FitContext context)
    {
        this._context = context;
        
    }
public async Task<Aluno[]> GetAllAlunosByNomeAsync(string nome = "")
    {
        IQueryable<Aluno> query = _context.Alunos;
        return await query.AsNoTracking().OrderBy(a => a.NomeAluno).Where(a => a.NomeAluno != null && a.NomeAluno.ToLower().Contains(nome.ToLower())).ToArrayAsync();
    }

    public async Task<Treino[]> GetAllTreinosByAlunoAsync(int AlunoId)
    {
        IQueryable<Treino> query = _context.Treinos;
        return await query.AsNoTracking().OrderByDescending(t => t.Inicio).Where(t => t.AlunoId == AlunoId).ToArrayAsync();
    }

    public async Task<Aluno?> GetAlunoByIdAsync(int AlunoId)
    {
        IQueryable<Aluno> query = _context.Alunos;
        return await query.Where(t => t.Id == AlunoId)
                            .AsNoTracking()
                            .FirstOrDefaultAsync();
    }

    public async Task<Aluno[]> GetAllAlunosAsync()
    {
        IQueryable<Aluno> query = _context.Alunos;
        return await query.AsNoTracking().OrderBy(a => a.NomeAluno).ToArrayAsync();
    }
}