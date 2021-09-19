using DIO.PersonagensAPI.Entidade;
using DIO.PersonagensAPI.Interface;
using DIO.PersonagensAPI.Web.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.PersonagensAPI.Web.Controllers
{
    [Route("[controller]")]
    public class PersonagemController : Controller
    {
        private readonly IRepositorio<Personagem> _repositorioPersonagem;

        public PersonagemController(IRepositorio<Personagem> repositorioPersonagem)
        {
            _repositorioPersonagem = repositorioPersonagem;
        }

        [HttpGet("")]
        public IActionResult Lista()
        {
            var personagem = _repositorioPersonagem.Lista();

            return Ok(_repositorioPersonagem.Lista().Select(p => new PersonagemModel(p)));
        }

        [HttpGet("{id}")]
        public IActionResult RetornaPorId(int id)
        {
            Personagem personagem = _repositorioPersonagem.Lista().FirstOrDefault(p => p.Id == id);
            if(personagem != null)
            {
              return Ok(personagem.ToString());
            }

            return NotFound("Personagem não cadastrado");
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, [FromBody] PersonagemModel personagemModel)
        {        
            _repositorioPersonagem.Atualizar(id, personagemModel.ToPersonagem());

            return NoContent();                   
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id)
        {
            _repositorioPersonagem.Excluir(id);

            return NoContent();
        }

        [HttpPost("")]
        public IActionResult Inserir([FromBody] PersonagemModel personagemModel)
        { 
            personagemModel.Id = _repositorioPersonagem.ProximoId();

            Personagem personagem = personagemModel.ToPersonagem();

            _repositorioPersonagem.Inserir(personagem);

            return Created("", personagem.ToString());
        }

    }
}
