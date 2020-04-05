using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Repositorios;
using BuscaAcoes.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaAcoes.Dominio.Servicos
{
    public class ServicoAtivo : IServicoAtivo
    {
        private readonly IRepositorioAtivo _repositorioAtivo;

        public ServicoAtivo(IRepositorioAtivo repositorioAtivo)
        {
            _repositorioAtivo = repositorioAtivo;
        }

        public async Task<IEnumerable<Ativo>> ObterAtivos() =>
            await _repositorioAtivo.ObterAtivos();

        public async Task<DadosInvestimento> ObterResumoInvestimento(IEnumerable<Ativo> ativos)
        {
            ativos = ativos.OrderBy(o => o.Rentabilidade).ToList();
            return await Task.FromResult(new DadosInvestimento()
            {
                AtivoMaisRentavel = ativos.Last(p => p.Rentabilidade > 0).Codigo,
                AtivoMenosRentavel = ativos.First().Codigo,
                TotalGanho = ativos.Where(p => p.Rentabilidade > 0).Sum(s => s.Rentabilidade),
                TotalPerdido = ativos.Where(p => p.Rentabilidade < 0).Sum(s => s.Rentabilidade),
                TotalRentabilidade = ativos.Sum(s => s.Rentabilidade),
                TotalInvestimento = ativos.SelectMany(p => p.ValoresAtivo ?? new List<ValorAtivo>()).Sum(s => s.TotalInvestido),
                PossiveisCompras = ativos.Where(p => (((Convert.ToDecimal(p.Valor) - p.ValorDesejado) / p.ValorDesejado) * 100) < 5).Select(s => s.Codigo).ToList().Aggregate((A, B) => A + " | " + B)
            });
        }
    }
}
