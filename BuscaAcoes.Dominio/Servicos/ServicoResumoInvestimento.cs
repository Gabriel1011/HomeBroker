using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Repositorios;
using BuscaAcoes.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuscaAcoes.Dominio.Servicos
{
    public class ServicoResumoInvestimento : IServicoResumoInvestimento
    {
        private readonly IRepositorioResumoInvestimento _repositorioResumoInvestimento;

        public ServicoResumoInvestimento(IRepositorioResumoInvestimento repositorioResumoInvestimento)
        {
            _repositorioResumoInvestimento = repositorioResumoInvestimento;
        }

        public async Task GravarResumoInvestimento(ResumoInvestimento resumoInvestimento) =>
            await _repositorioResumoInvestimento.Adicionar(resumoInvestimento);
    }
}
