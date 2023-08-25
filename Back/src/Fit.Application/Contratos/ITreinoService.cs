using Fit.Domain.Models;

namespace Fit.Application.Contratos;
    public interface ITreinoService
    {
        Task<Aluno> AddTreino(Treino model);
        Task<Aluno> UpdateTreino(Treino model);
        Task<bool> DeleteTreino(int AlunoId);
    }
