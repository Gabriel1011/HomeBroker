using BuscaAcoes.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuscaAcoes.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioAtivo
    {
        Task<IEnumerable<Ativo>> ObterAtivos();
        Task Adicionar(List<Ativo> ativo);
        Task<IEnumerable<Ativo>> ListarTodosAtivos();
    }
}
