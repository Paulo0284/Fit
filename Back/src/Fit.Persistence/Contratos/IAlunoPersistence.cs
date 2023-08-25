using Fit.Domain.Models;

namespace Fit.Persistence.Contratos;

public interface IAlunoPersistence
{
    //ALUNOS
    Task<Aluno[]> GetAllAlunosAsync();
    Task<Aluno[]> GetAllAlunosByNomeAsync(string nome = "");
    Task<Treino[]> GetAllTreinosByAlunoAsync(int AlunoId);
    Task<Aluno?> GetAlunoByIdAsync(int AlunoId);

    
}