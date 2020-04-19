using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Repositorios;
using BuscaAcoes.Infraestrutura.GerarAquivo;
using System.Threading.Tasks;

namespace BuscaAcoes.Infraestrutura.Dados
{
    public class RepositorioConfiguracao : IRepositorioConfiguracao
    {
        private readonly GerarAquivosIniciais<Configuracao> _gerarRepositorio;

        public RepositorioConfiguracao(GerarAquivosIniciais<Configuracao> gerarRepositorio)
        {
            _gerarRepositorio = gerarRepositorio;
            _gerarRepositorio.Caminho = _gerarRepositorio.ArquivoConfiguracao;
        }

        public async Task Atualizar(Configuracao Novaconfiguracoa) =>
            await _gerarRepositorio.GerarJsons(Novaconfiguracoa);

        public async Task<Configuracao> Obter() =>
            await _gerarRepositorio.Obter();

    }
}
