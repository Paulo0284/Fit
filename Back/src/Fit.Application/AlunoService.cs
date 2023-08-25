using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using Fit.Application.Contratos;
using Fit.Domain.Models;
using Fit.Persistence.Contratos;

namespace Fit.Application
{
    public class AlunoService : IAlunoService
    {
        private readonly IFitPersistence _fitPersistence;
        private readonly IAlunoPersistence _alunoPersistence;

        public AlunoService(IFitPersistence fitPersistence,IAlunoPersistence alunoPersistence)
        {
            _alunoPersistence = alunoPersistence;
            _fitPersistence = fitPersistence;
            
        }
        public async Task<Aluno?> AddAluno(Aluno model)
        {
            try
            {
                _fitPersistence.Add<Aluno>(model);
                if(await _fitPersistence.SaveChangesAsync()){
                    return await _alunoPersistence.GetAlunoByIdAsync(model.Id);
                }
                return null;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Aluno?> UpdateAluno(Aluno model)
        {
            try
            {
                _fitPersistence.Update<Aluno>(model);
                await _fitPersistence.SaveChangesAsync();
                return await _alunoPersistence.GetAlunoByIdAsync(model.Id);

            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteAluno(int AlunoId)
        {
           try
            {
                var aluno = await _alunoPersistence.GetAlunoByIdAsync(AlunoId);
                if(aluno == null) throw new Exception("Aluno não encontrado!");
                _fitPersistence.Delete<Aluno>(aluno);
                return await _fitPersistence.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Aluno[]> GetAllAlunosAsync()
        {
            try
            {
                var alunos = await _alunoPersistence.GetAllAlunosAsync();
                return alunos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Aluno[]> GetAllAlunosByNomeAsync(string nome = "")
        {
            try
            {
                var alunos = await _alunoPersistence.GetAllAlunosByNomeAsync(nome);
                return alunos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Treino[]> GetAllTreinosByAlunoAsync(int AlunoId)
        {
            try
            {
                var treinos = await _alunoPersistence.GetAllTreinosByAlunoAsync(AlunoId);
                return treinos;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

        public async Task<Aluno?> GetAlunoByIdAsync(int AlunoId)
        {
            try
            {
                var aluno = await _alunoPersistence.GetAlunoByIdAsync(AlunoId);
                return aluno;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }

       
    }
}