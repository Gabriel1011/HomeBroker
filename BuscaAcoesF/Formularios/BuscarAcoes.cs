using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Servicos;
using BuscaAcoesF.Formularios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaAcoesF
{
    public partial class BuscarAcoes : Form
    {
        private readonly IServicoAtivo _servicoAtivo;
        private readonly IServicoResumoInvestimento _servicoResumoInvestimento;
        private IEnumerable<Ativo> _ativos;
        private DadosInvestimento _dadosInvestimento;

        Point localizacaoOriginal;
        Screen tela = Screen.AllScreens.FirstOrDefault(p => !p.Primary) ?? Screen.AllScreens.FirstOrDefault(p => p.Primary);
        public BuscarAcoes(IServicoAtivo servicoAtivo, IServicoResumoInvestimento servicoResumoInvestimento)
        {
            InitializeComponent();
            this.Size = new Size(369, this.Size.Height);
            this.Location = tela.WorkingArea.Location;
            _servicoAtivo = servicoAtivo;
            _servicoResumoInvestimento = servicoResumoInvestimento;
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

            dataGridView1.Columns["Link"].Visible = false;
            dataGridView1.Columns["Verde"].Visible = false;
            dataGridView1.Columns["Vermelho"].Visible = false;
            dataGridView1.Columns["Ordem"].Visible = false;
            dataGridView1.Columns["QuantidadeCotas"].Visible = false;
            dataGridView1.Columns["Rentavel"].Visible = false;
            dataGridView1.Columns["Comprar"].Visible = false;
            dataGridView1.Columns["TotalInvestido"].Visible = false;
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
            if (btnRedimencionar.Text == ">")
            {
                localizacaoOriginal = this.Location;
                this.Location = new Point(this.Location.X - 1200, this.Location.Y);
                this.Size = new Size(1150, this.Size.Height);
                btnRedimencionar.Text = "<";
            }
            else
            {
                this.Location = localizacaoOriginal;
                this.Size = new Size(369, this.Size.Height);
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

        private void btnGerarResumo_Click(object sender, EventArgs e)
        {
            var resumoInvestimento = new ResumoInvestimento(_ativos.ToList(), _dadosInvestimento);
            _servicoResumoInvestimento.GravarResumoInvestimento(resumoInvestimento);
        }
    }
}
