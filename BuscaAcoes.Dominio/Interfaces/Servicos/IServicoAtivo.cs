using BuscaAcoes.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuscaAcoes.Dominio.Interfaces.Servicos
{
    public interface IServicoAtivo
    {
        Task<IEnumerable<Ativo>> ObterAtivos();
        Task<DadosInvestimento> ObterResumoInvestimento(IEnumerable<Ativo> ativos);
    }
}
