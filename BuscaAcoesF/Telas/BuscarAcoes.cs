using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Servicos;
using BuscaAcoesF.Formularios;
using BuscaAcoesF.Formularios.Estilo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaAcoesF
{
    public partial class BuscarAcoes : FormBase
    {
        private readonly IServicoAtivo _servicoAtivo;
        private readonly IServicoResumoInvestimento _servicoResumoInvestimento;
        private IEnumerable<Ativo> _ativos;
        private DadosInvestimento _dadosInvestimento;
        private int _indexLinhaStripMenu;
        Point localizacaoOriginal, telaOriginal;
        Screen tela = Screen.AllScreens.FirstOrDefault(p => !p.Primary) ?? Screen.AllScreens.FirstOrDefault(p => p.Primary);


        public BuscarAcoes(IServicoAtivo servicoAtivo, IServicoResumoInvestimento servicoResumoInvestimento)
        {
            InitializeComponent();

            _servicoAtivo = servicoAtivo;
            _servicoResumoInvestimento = servicoResumoInvestimento;
            FormatarTela(this);
            FormatarTela();
        }

        private async void BuscarAcoes_Load(object sender, System.EventArgs e)
        {
            await ObterDadosAtualizados();
        }

        private async Task ObterDadosAtualizados()
        {
            await Task.Run(async () =>
            {
                _ativos = _servicoAtivo.ObterAtivos().Result;

                dataGridView1.Invoke(new Action(() =>
                {
                    dataGridView1.DataSource = _ativos;
                }));

                await FormatarValores();
                await AtualizarData();
                await GerarNumeros();
            });
        }


        public async Task AtualizarData() => lbDataAtualizacao.Invoke(new Action(() => { lbDataAtualizacao.Text = DateTime.Now.ToString(); }));

        private void checkBox1_CheckedChanged(object sender, EventArgs e) => this.TopMost = ckbTop.Checked;

        private async void ckbAtualizar_CheckedChanged(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                while (ckbAtualizar.Checked)
                {
                    await ObterDadosAtualizados();
                    Thread.Sleep(60000);
                }
            });
        }


        private async Task FormatarValores() => dataGridView1.Invoke(new Action(() =>
        {
            OcultarCampos();
            FormataGrid();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var ativo = _ativos.ToList().FirstOrDefault(p => p.Codigo == row.Cells["Codigo"].Value.ToString());

                if (ativo.Vermelho)
                    dataGridView1.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Red;

                else if (ativo.Verde)
                    dataGridView1.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Green;

                if (ativo.Rentavel)
                    dataGridView1.Rows[row.Index].Cells["Rentabilidade"].Style.BackColor = Color.LightGreen;
                else if (ativo.Rentabilidade < 0)
                    dataGridView1.Rows[row.Index].Cells["Rentabilidade"].Style.BackColor = Color.LightPink;

                if (ativo.Comprar)
                    dataGridView1.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGreen;
            }
        }));

        private void OcultarCampos()
        {
            if (dataGridView1.Rows.Count == 0)
                return;

            dataGridView1.HideColumnDataGrid(new List<string>() {
            "Link",
            "Verde",
            "Vermelho",
            "Amarelo",
            "Ordem",
            "QuantidadeCotas",
            "Rentavel",
            "Comprar",
            "TotalInvestido"});
        }

        public decimal ObterValor(string texto)
        {
            var valor = texto.Split(' ')[0].Remove(0, 1);
            return Convert.ToDecimal(valor);
        }

        private async void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            System.Diagnostics.Process.Start(dataGridView1.Rows[e.RowIndex].Cells["Link"].Value.ToString());
        }

        private async void btnCadastro_Click(object sender, EventArgs e)
        {
            CompositionRoot.Resolve<CadastroAtivo>().ShowDialog();
            await ObterDadosAtualizados();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            RedimencionarTela();
        }

        private void RedimencionarTela()
        {
            if (btnRedimencionar.Text == ">")
            {
                this.Location = localizacaoOriginal.IsEmpty ? this.Location : localizacaoOriginal;
                this.Size = new Size(285, this.Size.Height);
                dataGridView1.Size = new Size(278, 406);
                btnRedimencionar.Text = "<";
            }
            else
            {

                localizacaoOriginal = this.Location;
                this.Location = new Point(this.Location.X - 1200, this.Location.Y);
                this.Size = new Size(932, this.Size.Height);
                dataGridView1.Size = new Size(632, 406);
                btnRedimencionar.Text = ">";
            }
        }

        private async Task GerarNumeros()
        {
            var ativos = _ativos.OrderBy(o => o.Rentabilidade);
            _dadosInvestimento = await _servicoAtivo.ObterResumoInvestimento(_ativos);

            await Task.Run(() =>
            {
                lblMaisRentavel.Invoke(new Action(() => { lblMaisRentavel.Text = _dadosInvestimento.AtivoMaisRentavel; }));
                lblMenoRentavel.Invoke(new Action(() => { lblMenoRentavel.Text = _dadosInvestimento.AtivoMenosRentavel; }));
                lblTotalGanho.Invoke(new Action(() => { lblTotalGanho.Text = _dadosInvestimento.TotalGanho.ToString(); }));
                lblTotalPerda.Invoke(new Action(() => { lblTotalPerda.Text = _dadosInvestimento.TotalPerdido.ToString(); }));
                lblTotalRentabilidade.Invoke(new Action(() => { lblTotalRentabilidade.Text = _dadosInvestimento.TotalRentabilidade.ToString(); }));
                lblTotalInvestido.Invoke(new Action(() => { lblTotalInvestido.Text = _dadosInvestimento.TotalInvestimento.ToString(); }));
                lblTotalRetorno.Invoke(new Action(() => { lblTotalRetorno.Text = _dadosInvestimento.TotalRetorno.ToString(); }));
                lblPossiveisCompras.Invoke(new Action(() => { lblPossiveisCompras.Text = _dadosInvestimento.PossiveisCompras; }));
            });
        }

        private async void btnGerarResumo_Click(object sender, EventArgs e)
        {
            var resumoInvestimento = new ResumoInvestimento(_ativos.ToList(), _dadosInvestimento);
            await _servicoResumoInvestimento.GravarResumoInvestimento(resumoInvestimento);
        }

        private void FormataGrid()
        {
            dataGridView1.DarkDataGridView();
        }

        private void FormatarTela()
        {
            //this.Size = new Size(285, this.Size.Height);
            //dataGridView1.Size = new Size(278, 406);
            this.Location = tela.WorkingArea.Location;
        }

        private void BuscarAcoes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RedimencionarTela();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button && _indexLinhaStripMenu > -1)
            {
                ContextMenuStrip menu = new ContextMenuStrip();

                _indexLinhaStripMenu = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                var codigoAtivo = dataGridView1.Rows[_indexLinhaStripMenu].Cells["Codigo"].Value.ToString();

                ApresentarMenu(e, menu, codigoAtivo);
            }
        }

        private void ApresentarMenu(MouseEventArgs e, ContextMenuStrip menu, string codigoAtivo)
        {
            menu.Items.Add($@"Abrir {codigoAtivo} no FundInvest").Name = "FundInvest";
            menu.Items.Add($@"Abrir {codigoAtivo} no StatusInvest").Name = "StatusInvest";
            menu.Items.Add($@"Abrir {codigoAtivo} no Google Finance").Name = "GoogleFinance";
            //menu.DarkContextMenuStrip();
            menu.Show(dataGridView1, new Point(e.X, e.Y));
            menu.ItemClicked += AbrirSite;
        }

        private void AbrirSite(object sender, ToolStripItemClickedEventArgs e)
        {
            var codigoAtivo = dataGridView1.Rows[_indexLinhaStripMenu].Cells["Codigo"].Value.ToString();

            switch (e.ClickedItem.Name)
            {
                case "FundInvest":
                    System.Diagnostics.Process.Start($@"https://www.fundsexplorer.com.br/funds/{codigoAtivo}");
                    break;
                case "StatusInvest":
                    System.Diagnostics.Process.Start($@"https://statusinvest.com.br/acoes/{codigoAtivo}");
                    break;
                case "GoogleFinance":
                    System.Diagnostics.Process.Start(dataGridView1.Rows[_indexLinhaStripMenu].Cells["Link"].Value.ToString());
                    break;

                default:
                    break;
            }
        }

    }
}
