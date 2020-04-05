using BuscaAcoes.Dominio.Entidades;
using System.Threading.Tasks;

namespace BuscaAcoes.Dominio.Interfaces.Servicos
{
    public interface IServicoResumoInvestimento
    {
        Task GravarResumoInvestimento(ResumoInvestimento resumoInvestimento);
    }
}
