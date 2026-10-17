using APIPessoas.Models.Contextos;
using APIPessoas.Models.Entidades;
using APIPessoas.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace APIPessoas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : Controller
    {
        RepositorioProdutos rep = new RepositorioProdutos();

        [HttpGet("ListarProdutos")]
        public IActionResult ListarProdutos()
        {
            var lista = rep.ListaProdutos();
            return Ok(lista);
        }

        [HttpGet("PesquisarProdutosID/{valorID}")]
        public IActionResult PesquisarProdutosID(int valorID)
        {
            try
            {
                var valor = rep.PesquisarProdutoID(valorID);
                if (valor != null)
                {
                    return Ok(valor);
                }
                else
                {
                    return NotFound("Dado não encontrado");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPost("CriarProdutos")]
        public IActionResult CriarProdutos([FromBody]Produtos produto)
        {            
            try
            {
                rep.CriarProdutos(produto);
                return Ok("Produto criado na base de dados");
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPut("AtualizarProdutos/{id}")]
        public IActionResult AtualizarProdutos(int id, [FromBody]Produtos produto)
        {
            try
            {
                Produtos p = rep.PesquisarProdutoID(id);
                if (p == null)
                {
                    return NotFound("Produto não encontrado na base de dados");
                }
                else
                {
                    rep.AtualizarProdutos(p, produto);
                    return Ok("Produto atualizado na base de dados");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }
    }
}
