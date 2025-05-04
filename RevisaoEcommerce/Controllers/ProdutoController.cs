using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RevisaoEcommerce.Models;

namespace RevisaoEcommerce.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet("listar")]
        public IActionResult listar()
        {
            var produtos = new List<Produto>
            {
                new Produto {Id = 1, Nome = "Teclado Gamer", Preco = 1000.00},
                new Produto {Id = 2, Nome = "Mouse Gamer", Preco  = 500.00}
            };

            return Ok (produtos);
        }

        [HttpPost("cadastrar")]
        public IActionResult cadastrar([FromBody] Produto produto)
        {
            return Created ("", produto);
        }

    }
}
