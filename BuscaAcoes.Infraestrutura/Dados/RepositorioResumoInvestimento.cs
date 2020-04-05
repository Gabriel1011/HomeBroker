using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Repositorios;
using BuscaAcoes.Infraestrutura.GerarAquivo;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscaAcoes.Infraestrutura.Dados
{
    public class RepositorioResumoInvestimento : IRepositorioResumoInvestimento
    {
        private readonly GerarAquivosIniciais<ResumoInvestimento> _gerarRepositorio;

        public RepositorioResumoInvestimento(GerarAquivosIniciais<ResumoInvestimento> gerarRepositorio)
        {
            _gerarRepositorio = gerarRepositorio;
            _gerarRepositorio.Caminho = _gerarRepositorio.ArquivoResumoInvestimento;
        }

        public async Task Adicionar(ResumoInvestimento resumoInvestimento)
        {
            var Resumos = await _gerarRepositorio.ObterLista();
            Resumos.Add(resumoInvestimento);
            _gerarRepositorio.GerarJsonLista(Resumos);
        }

        public async Task<IEnumerable<ResumoInvestimento>> ObterResumoInvestimento() =>
            await _gerarRepositorio.ObterLista();
    }
}
