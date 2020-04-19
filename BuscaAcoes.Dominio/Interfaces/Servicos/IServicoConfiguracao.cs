using BuscaAcoes.Dominio.Entidades;
using System.Threading.Tasks;

namespace BuscaAcoes.Dominio.Interfaces.Servicos
{
    public interface IServicoConfiguracao
    {
        Task Atualizar(Configuracao configuracoa);
        Task<Configuracao> Obter();
    }
}
