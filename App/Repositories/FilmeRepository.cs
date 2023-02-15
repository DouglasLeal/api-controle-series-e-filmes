using App.Data;
using App.Interfaces;
using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly ApplicationDbContext _context;

        public FilmeRepository(ApplicationDbContext context) {
            _context = context;
        }

        public async Task Criar(Filme filme)
        {
            await _context.Filmes.AddAsync(filme);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<Filme>> Listar()
        {
            return await _context.Filmes.ToListAsync();
        }

        public async Task<Filme?> BuscarPorId(int id)
        {
            return await _context.Filmes.FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task Atualizar(Filme filme)
        {
            _context.Filmes.Update(filme);
            await _context.SaveChangesAsync();
        }      

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task Excluir(Filme filme)
        {
            _context.Filmes.Remove(filme);
            await _context.SaveChangesAsync();
        }

        
    }
}
