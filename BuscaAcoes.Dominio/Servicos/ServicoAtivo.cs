using BuscaAcoes.Dominio.Auxiliar;
using BuscaAcoes.Dominio.Auxiliar.Extensoes;
using BuscaAcoes.Dominio.Auxiliar.Notificacoes;
using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Repositorios;
using BuscaAcoes.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuscaAcoes.Dominio.Servicos
{
    public class ServicoAtivo : IServicoAtivo
    {
        private readonly IRepositorioAtivo _repositorioAtivo;
        private readonly IRepositorioResumoInvestimento _repositorioResumoInvestimento;
        private readonly INotificador _notificacao;
        private readonly ConfiguracoesSistema _configuracao;

        public ServicoAtivo(IRepositorioAtivo repositorioAtivo,
            IRepositorioResumoInvestimento repositorioResumoInvestimento,
            INotificador notificacao, ConfiguracoesSistema configuracao)
        {
            _repositorioAtivo = repositorioAtivo;
            _repositorioResumoInvestimento = repositorioResumoInvestimento;
            _notificacao = notificacao;
            _configuracao = configuracao;
        }

        public async Task<IEnumerable<Ativo>> ObterAtivos()
        {
            if(_configuracao.Config.ModoDesenvolvimento)
                return await ObterUltimoResumo();

            if (DateTime.Now.Hour < 18 && DateTime.Now.Hour > 9)
            {
                try
                {
                    _notificacao.AtualizarErroOrigem();
                    return await _repositorioAtivo.ObterAtivos();
                }
                catch (Exception ex)
                {
                    return await ObterUltimoResumo();
                }
            }
            else
            {
                return await ObterUltimoResumo();
            }
        }

        private async Task<IEnumerable<Ativo>> ObterUltimoResumo()
        {
            _notificacao.AtualizarErroOrigem(true);
            return await ObterAtivosPorHistoricoResumo();
        }

        private async Task<IEnumerable<Ativo>> ObterAtivosPorHistoricoResumo()
        {
            var resumos = await _repositorioResumoInvestimento.ObterResumoInvestimento();
            return resumos.OrderByDescending(o => o.DataResumo).FirstOrDefault().Ativos;
        }

        public async Task<DadosInvestimento> ObterResumoInvestimento(IEnumerable<Ativo> ativos)
        {
            ativos = ativos.OrderBy(o => o.Rentabilidade).ToList();
            return await Task.FromResult(new DadosInvestimento()
            {
                AtivoMaisRentavel = ativos.Where(p => p.Rentabilidade != 0).Last(p => p.Rentabilidade > 0).Codigo,
                AtivoMenosRentavel = ativos.Where(p => p.Rentabilidade != 0).First().Codigo,
                TotalGanho = ativos.Where(p => p.Rentabilidade > 0).Sum(s => s.Rentabilidade),
                TotalPerdido = ativos.Where(p => p.Rentabilidade < 0).Sum(s => s.Rentabilidade),
                TotalRentabilidade = ativos.Sum(s => s.Rentabilidade),
                TotalInvestimento = ativos.SelectMany(p => p.ValoresAtivo ?? new List<ValorAtivo>()).Sum(s => s.TotalInvestido),
                PossiveisCompras = await GerarPossiveisCompras(ativos)
            });
        }

        private async Task<string> GerarPossiveisCompras(IEnumerable<Ativo> ativos)
        {
            var possiveisCompras = ativos.Where(p => p.Variacao < _configuracao.Config.PorcentagemVariavao)
                .Select(s => s.Codigo).ToList().Aggregate((A, B) => A + " | " + B);

            if (possiveisCompras.Count(p => p == '|') >= 3)
            {
                var inds = await possiveisCompras.IndexesOf('|');
                possiveisCompras = await possiveisCompras.Inserts(inds.GetIndexesMod(3), "\n");
            }

            return possiveisCompras;
        }
    }
}
