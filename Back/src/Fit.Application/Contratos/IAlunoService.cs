using Fit.Domain.Models;

namespace Fit.Application.Contratos;
    public interface IAlunoService
    {
        Task<Aluno?> AddAluno(Aluno model);
        Task<Aluno?> UpdateAluno(Aluno model);
        Task<bool> DeleteAluno(int AlunoId);
         Task<Aluno[]> GetAllAlunosAsync();
        Task<Aluno[]> GetAllAlunosByNomeAsync(string nome = "");
        Task<Treino[]> GetAllTreinosByAlunoAsync(int AlunoId);
        Task<Aluno?> GetAlunoByIdAsync(int AlunoId);
    }
