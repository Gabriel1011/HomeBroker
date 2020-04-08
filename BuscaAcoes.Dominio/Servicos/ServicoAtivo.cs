using BuscaAcoes.Dominio.Auxiliar.Extensoes;
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

        public ServicoAtivo(IRepositorioAtivo repositorioAtivo,
            IRepositorioResumoInvestimento repositorioResumoInvestimento)
        {
            _repositorioAtivo = repositorioAtivo;
            _repositorioResumoInvestimento = repositorioResumoInvestimento;
        }

        public async Task<IEnumerable<Ativo>> ObterAtivos()
        {
            if (DateTime.Now.Hour < 18)
                return await _repositorioAtivo.ObterAtivos();
            else
            {
                var resumos = await _repositorioResumoInvestimento.ObterResumoInvestimento();

                return resumos.OrderByDescending(o => o.DataResumo).FirstOrDefault().Ativos;
            }

        }

        public async Task<DadosInvestimento> ObterResumoInvestimento(IEnumerable<Ativo> ativos)
        {
            ativos = ativos.OrderBy(o => o.Rentabilidade).ToList();
            var possiveisCompras = ativos.Where(p => (((Convert.ToDecimal(p.Valor) - p.ValorDesejado) / p.ValorDesejado) * 100) < 5).Select(s => s.Codigo).ToList().Aggregate((A, B) => A + " | " + B);

            if (possiveisCompras.Count(p => p == '|') > 3)
            {
                var inds = await possiveisCompras.IndexesOf('|');
                possiveisCompras = await possiveisCompras.Inserts(inds.GetIndexesMod(3), "\n");
            }

            return await Task.FromResult(new DadosInvestimento()
            {
                AtivoMaisRentavel = ativos.Last(p => p.Rentabilidade > 0).Codigo,
                AtivoMenosRentavel = ativos.First().Codigo,
                TotalGanho = ativos.Where(p => p.Rentabilidade > 0).Sum(s => s.Rentabilidade),
                TotalPerdido = ativos.Where(p => p.Rentabilidade < 0).Sum(s => s.Rentabilidade),
                TotalRentabilidade = ativos.Sum(s => s.Rentabilidade),
                TotalInvestimento = ativos.SelectMany(p => p.ValoresAtivo ?? new List<ValorAtivo>()).Sum(s => s.TotalInvestido),
                PossiveisCompras = possiveisCompras
            });
        }
    }
}
