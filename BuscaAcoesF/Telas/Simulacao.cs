using BuscaAcoes.Dominio.Auxiliar;
using BuscaAcoes.Dominio.Entidades;
using BuscaAcoesF.Formularios.Estilo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace BuscaAcoesF.Telas
{
    public partial class Simulacao : FormBase
    {
        private readonly ConfiguracoesSistema _configuracao;
        public List<Ativo> Ativos { get; set; }
        public bool Venda { get; set; }
        public List<string> AtivosSimulados { get; set; }

        public Simulacao(ConfiguracoesSistema configuracao)
        {
            InitializeComponent();
            FormatarTela(this);
            _configuracao = configuracao;            
        }

        public async Task GerarSimulacao()
        {
            Ativos = Ativos.Where(p => AtivosSimulados.Contains(p.Codigo) && (p.ValoresAtivo?.Any() ?? false)).ToList();

            lblAtivos.Text = Ativos.Select(p => p.Codigo).Aggregate((A, B) => A + " | " + B);

            var totalInvestido = Ativos.Sum(p => p.ValorMerdioPago * p.ValoresAtivo.Sum(s => s.Quantidade));
            var totalVendido = Ativos.Sum(p => Convert.ToDecimal(p.Valor) * p.ValoresAtivo.Sum(s => s.Quantidade));
            var TotalCorretagem = _configuracao.Config.ValorCorretagem * Ativos.Count;
            var TotalLucro = totalVendido - totalInvestido;
            var lucro = TotalLucro - TotalCorretagem;

            //lblQuantidadeAtivos.Text = (await GerarQuantidadePorAtivo()).Aggregate((A, B) => A + " | " + B);
            //lblValorAtivos.Text = (await GerarValorPorAtivo()).Aggregate((A, B) => A + " | " + B);
            lblValorInvestido.Text = totalInvestido.ToString();
            lblValorVenda.Text = totalVendido.ToString();
            lblTotalLucro.Text = TotalLucro.ToString();
            lblTotalCorretagem.Text = TotalCorretagem.ToString();
            lblLucro.Text = lucro.ToString();

            (await GerarQuantidadePorAtivo()).ToList().ForEach(info => { listInformacoesPorAtivo.Items.Add(info); });

            var teste = (await GerarInformacoesAtivos()).ToList();
        }

        private void Simulacao_Load(object sender, EventArgs e)
        {
            GerarSimulacao();
        }

        public async Task<IEnumerable<string>> GerarQuantidadePorAtivo()
        {
            return await Task.FromResult(Ativos.Select(
                p => $"{p.Codigo}: {p.ValoresAtivo.Sum(s => s.Quantidade)} - Valor: {p.Valor} - Valor Total: {p.ValoresAtivo.Sum(s => s.Quantidade) * Convert.ToDecimal(p.Valor)} - Investimento: {p.ValoresAtivo.Sum(s => s.ValorPago * s.Quantidade)}"));
        }
        public async Task<IEnumerable<string>> GerarValorPorAtivo()
        {
            return await Task.FromResult(Ativos.Select(p => $"{p.Codigo}: {p.Valor}"));
        }

        public async Task<IEnumerable<(string Ativo, string Quantidade, string valor, string ValorTotal)>> GerarInformacoesAtivos()
        {
            var informacoesAtivo = Ativos.Select(p => (Ativo: p.Codigo, Quantidade: p.ValoresAtivo.Sum(s => s.Quantidade).ToString(), valor: p.Valor, ValorTotal: (p.ValoresAtivo.Sum(s => s.Quantidade) * Convert.ToDecimal(p.Valor)).ToString()));

            return await Task.FromResult(informacoesAtivo);
        }
    }
}
