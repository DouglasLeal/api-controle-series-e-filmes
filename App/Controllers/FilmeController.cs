using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Criar()
        {
            return Ok();
        }

        [HttpPut("/{id:int}")]
        public async Task<IActionResult> Atualizar(int id)
        {
            return Ok();
        }

        [HttpDelete("/{id:int}")]
        public async Task<IActionResult> Excluir(int id)
        {
            return Ok();
        }
    }
}
