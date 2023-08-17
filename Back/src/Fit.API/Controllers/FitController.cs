using Fit.API.Data;
using Fit.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FitController : ControllerBase
{
    private readonly DataContext _contexto;
   public FitController(DataContext context)
    {
            this._contexto = context;

    }

    [HttpGet]
    public IEnumerable<Aluno> Get()
    {
       return _contexto.Alunos.ToList();
    }

    [HttpGet("{id}")]
    public Aluno? Get(int id)
    {
       return _contexto.Alunos.FirstOrDefault(alu => alu.IdAluno == id);
    }

    [HttpPost]
    public string Post()
    {
       return "Exemplo de POST";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
       return $"Exemplo de PUT com id {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
       return $"Exemplo de DELETE com id {id}";
    }
}

