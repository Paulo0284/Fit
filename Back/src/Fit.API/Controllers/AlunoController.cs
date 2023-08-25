using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Fit.Application.Contratos;
using Fit.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Fit.API.Controllers
{
    [Route("api/[controller]")]
    public class AlunoController : Controller
    {
        public IAlunoService _alunoService { get; }

        public AlunoController(IAlunoService alunoService)
        {
            this._alunoService = alunoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(){
            try
            {
                var alunos = await _alunoService.GetAllAlunosAsync();
                if(alunos == null){
                    return NotFound("Nenhum aluno cadastrado!");
                }
                return Ok(alunos);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Erro ao tentar recuperar Alunos. Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id){
            try
            {
                var aluno = await _alunoService.GetAlunoByIdAsync(id);
                if(aluno == null){
                    return NotFound("Aluno não encontrato!");
                }
                return Ok(aluno);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Erro ao tentar recuperar aluno. Erro: {ex.Message}");
            }
        }

        [HttpGet("{nome}/busca")]
        public async Task<IActionResult> GetByNome(string nome){
            try
            {
                var alunos = await _alunoService.GetAllAlunosByNomeAsync(nome);
                
                if(alunos == null){
                    return NotFound("Aluno não encontrato!");
                }
                return Ok(alunos);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Erro ao tentar recuperar aluno {nome}. Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}/treinos")]
        public async Task<IActionResult> GetTreinosAluno(int id){
            try
            {
                var alunos = await _alunoService.GetAllTreinosByAlunoAsync(id);
                
                if(alunos == null){
                    return NotFound("Aluno não possui treinos cadastrados!");
                }
                return Ok(alunos);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Erro ao tentar recuperar treinos do aluno. Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(Aluno model){
            try
            {
                var aluno = await _alunoService.AddAluno(model);
                if(aluno == null) return BadRequest("Aluno não adicionado");
                return Ok(aluno);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Erro ao tentar adicionar aluno. Erro: {ex.Message}");
                
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id,Aluno model){
            try
            {
                var aluno = await _alunoService.UpdateAluno(model);
                if(aluno == null) return BadRequest("Aluno não atualizado!");
                return Ok(aluno);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Erro ao tentar atualizar aluno. Erro: {ex.Message}");
                
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id){
            try
            {
                if(await _alunoService.DeleteAluno(id)){
                    return Ok("Aluno deletado com sucesso!");
                }else{
                    return BadRequest("Aluno não excluído!");
                }
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,$"Erro ao tentar excluir aluno. Erro: {ex.Message}");
                
            }
        }

    }
}