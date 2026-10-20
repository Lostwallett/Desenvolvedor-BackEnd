using Banco.Classes.Models.Entidades;
using Banco.Classes.Repositorios;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Banco.Classes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        RepositorioContas rep = new RepositorioContas();

        // GET: api/<ContasController>
        [HttpGet]
        public IEnumerable<ContaBancaria> Get()
        {
            return rep.ListarContas();
        }

        // GET api/<ContasController>/5
        [HttpGet("{id}")]
        public IActionResult PesquisarContaPorNumero(int id)
        {
            try
            {
                var pesquisa = rep.PesquisarContas(id);
                if (pesquisa != null)
                {
                    return Ok(pesquisa);
                }
                else
                {
                    return NotFound("Conta não encontrada");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<ContasController>
        [HttpPost]
        public IActionResult Post([FromBody] ContaBancaria conta)
        {
            try
            {                
                rep.CriarConta(conta);
                return Created("Conta criada com sucesso!", conta);
                
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException ex)
            {
                return Conflict(ex.Message);
            }

        }

        // PUT api/<ContasController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ContaBancaria conta)
        {
            try
            {
                conta.NumeroConta = id;
                if (rep.EditarConta(conta))
                {
                    return Ok("Conta editada com sucesso");
                }
                else
                {
                    return NotFound("Conta não encontrada!");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ContasController>/5
        [HttpDelete("{numero}")]
        public IActionResult DeletarConta(int numero)
        {
            try
            {
                var existe = rep.PesquisarContas(numero);
                if (existe != null)
                {
                    rep.DeletarConta(numero);
                    return Ok("Conta deletada com sucesso");
                }
                else
                {
                    return NotFound("Conta bancária não encontrada");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
