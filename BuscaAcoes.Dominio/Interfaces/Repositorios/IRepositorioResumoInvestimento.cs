using BuscaAcoes.Dominio.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BuscaAcoes.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioResumoInvestimento
    {
        Task<IEnumerable<ResumoInvestimento>> ObterResumoInvestimento();
        Task Adicionar(ResumoInvestimento resumoInvestimento);
    }
}
