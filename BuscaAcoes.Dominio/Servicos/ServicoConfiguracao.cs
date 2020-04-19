using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Repositorios;
using BuscaAcoes.Dominio.Interfaces.Servicos;
using System;
using System.Threading.Tasks;

namespace BuscaAcoes.Dominio.Servicos
{
    public class ServicoConfiguracao : IServicoConfiguracao
    {
        private readonly IRepositorioConfiguracao _repositorioConfiguracao;

        public ServicoConfiguracao(IRepositorioConfiguracao repositorioConfiguracao)
        {
            _repositorioConfiguracao = repositorioConfiguracao;
        }

        public async Task Atualizar(Configuracao configuracoa)
        {
            await _repositorioConfiguracao.Atualizar(configuracoa);
        }

        public Task<Configuracao> Obter() =>
            _repositorioConfiguracao.Obter();
    }
}
