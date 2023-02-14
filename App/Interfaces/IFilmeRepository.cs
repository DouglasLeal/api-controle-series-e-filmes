using App.Models;

namespace App.Interfaces
{
    public interface IFilmeRepository : IDisposable
    {
        Task Criar(Filme filme);
        Task<Filme> BuscarPorId(int id);
        Task<IList<Filme>> Listar();
        Task Atualizar(Filme filme);
        Task Excluir(Filme filme);
    }
}
