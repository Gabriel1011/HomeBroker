using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Repositorios;
using BuscaAcoes.Infraestrutura.GerarAquivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BuscaAcoes.Infraestrutura.Dados
{
    public class RepositorioAtivo : IRepositorioAtivo
    {
        private readonly GerarAquivosIniciais<Ativo> _gerarRepositorio;

        public RepositorioAtivo(GerarAquivosIniciais<Ativo> gerarRepositorio)
        {
            _gerarRepositorio = gerarRepositorio;
            _gerarRepositorio.Caminho = _gerarRepositorio.ArquivoCadastroAtivos;
        }

        public async Task<IEnumerable<Ativo>> ObterAtivos()
        {
            var ativos = new List<Ativo>();
            var conexao = new WebClient();
            var acoes = await ListarTodosAtivos();

            foreach (var acao in acoes)
            {
                var link = $@"https://www.google.com/finance?q={acao.Codigo}";

                var pag =
                      conexao.DownloadString(link);

                var indx = pag.Split(new char[] { '<', '>' });
                var valor = indx.Where(p => p.Contains(",") && p.Length < 10 && p.Length > 2 && !p.Trim().EndsWith(",")).FirstOrDefault();
                var porcentagem = indx.Where(p => p.Contains(",") && p.Length < 20 && p.Contains(')')).FirstOrDefault();

                acao.AdicionarValores(valor, porcentagem, link);

                acao.ValoresAtivo?.ForEach((ValorAtivo) => { ValorAtivo.AdicionarValor(valor); });

                ativos.Add(acao);

            }
          
            return await Task.FromResult(ativos.OrderBy(o => o.Ordem).ToList());
        }

        public async Task<IEnumerable<Ativo>> ListarTodosAtivos() =>
            await _gerarRepositorio.ObterLista();

        public async Task Adicionar(List<Ativo> ativo)
        {
            _gerarRepositorio.GerarJsonLista(ativo);
        }
    }
}
