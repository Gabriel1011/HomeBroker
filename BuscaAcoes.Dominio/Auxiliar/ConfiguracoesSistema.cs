using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Servicos;
using System.Threading.Tasks;

namespace BuscaAcoes.Dominio.Auxiliar
{
    public class ConfiguracoesSistema
    {
        public Configuracao Config { get; set; }
        private readonly IServicoConfiguracao _servicoConfiguracao;

        public ConfiguracoesSistema(IServicoConfiguracao servicoConfiguracao)
        {
            _servicoConfiguracao = servicoConfiguracao;
            Config = _servicoConfiguracao.Obter().Result;
        }

        public async Task AtualizarConfiguracoesSistema(Configuracao configuracoesSistema) => 
            await Task.Run(() => Config = configuracoesSistema);
    }
}
