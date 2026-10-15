using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace APIPessoas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {   
            string texto = "API funcionou!";
            return Ok(texto);
        }
        [HttpGet("Home1")]
        public IActionResult Index1()
        {   
            string texto = "Nova rota funcionou!";
            return Ok(texto);
        }
    }
}
