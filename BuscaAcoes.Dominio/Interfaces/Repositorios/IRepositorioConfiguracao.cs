using BuscaAcoes.Dominio.Entidades;
using System.Threading.Tasks;

namespace BuscaAcoes.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioConfiguracao
    {
        Task Atualizar(Configuracao configuracoa);
        Task<Configuracao> Obter();
    }
}
