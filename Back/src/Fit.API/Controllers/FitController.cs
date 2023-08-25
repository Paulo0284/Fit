using Fit.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Fit.Persistence.Contextos;

namespace Fit.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FitController : ControllerBase
{
    private readonly FitContext _contexto;
   public FitController(FitContext context)
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
       return _contexto.Alunos.FirstOrDefault(alu => alu.Id == id);
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

