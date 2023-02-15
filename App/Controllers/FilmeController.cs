using App.Interfaces;
using App.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private readonly IFilmeRepository _repository;

        public FilmeController(IFilmeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var filmes = await _repository.Listar();
            return Ok(filmes);
        }

        [HttpGet("/{id:int}")]
        public async Task<IActionResult> BuscarPorId(int id)
        {
            var filme = await _repository.BuscarPorId(id);

            if (filme == null) return NotFound();

            return Ok(filme);
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] Filme filme)
        {
            await _repository.Criar(filme);

            return CreatedAtAction(nameof(BuscarPorId), new { id = filme.Id }, filme);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Atualizar(int id, [FromBody] Filme filme)
        {
            var filmeCadastrado = await _repository.BuscarPorId(id);

            if (filmeCadastrado == null) return NotFound();

            filmeCadastrado.Nota = filme.Nota;
            filmeCadastrado.Assistido = filme.Assistido;
            filmeCadastrado.TituloOriginal = filme.TituloOriginal;
            filmeCadastrado.TituloBrasileiro = filme.TituloBrasileiro;
            filmeCadastrado.Genero = filme.Genero;
            filmeCadastrado.Lancamento = filme.Lancamento;
            filmeCadastrado.Descricao = filme.Descricao;

            await _repository.Atualizar(filmeCadastrado);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Excluir(int id)
        {
            var filme = await _repository.BuscarPorId(id);

            if (filme == null) return NotFound();

            await _repository.Excluir(filme);

            return NoContent();
        }
    }
}
