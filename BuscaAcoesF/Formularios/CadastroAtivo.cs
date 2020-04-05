using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaAcoesF.Formularios
{
    public partial class CadastroAtivo : Form
    {
        private readonly IRepositorioAtivo _repositorioAtivo;
        private IEnumerable<Ativo> _ativos;
        public CadastroAtivo(IRepositorioAtivo repositorioAtivo)
        {
            InitializeComponent();
            _repositorioAtivo = repositorioAtivo;
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            var ativos = _ativos.ToList();

            await AdicionarAtivo(ativos);

            await AlterarOrdem(ativos);

            await _repositorioAtivo.Adicionar(ativos);
            _ativos = ativos;

            PreencherGrid(ativos);

        }

        private async Task AdicionarAtivo(List<Ativo> ativos)
        {
            await Task.Run(() =>
            {
                var ativo = ativos.FirstOrDefault(p => p.Codigo == txtCodigo.Text.ToUpper());
                if (ativo != null)
                    ativos.Remove(ativo);

                ativos.Add(new Ativo(txtCodigo.Text.ToUpper(),
                    Convert.ToDecimal(numValorbaixa.Text),
                    Convert.ToDecimal(numValorDesejado.Text),
                    Convert.ToInt32(numOrdem.Text)));
            });
        }

        public async Task AlterarOrdem(List<Ativo> ativos)
        {
            var ordem = Convert.ToInt32(numOrdem.Text);
            //if (ativos.FirstOrDefault(p => p.Codigo == txtCodigo.Text.ToUpper()).Ordem == ordem)
            //    return;

            await Task.Run(() =>
            {
                ativos
                   .Where(p => p.Ordem >= ordem && p.Codigo != txtCodigo.Text.ToUpper())
                   .ToList()
                   .ForEach((Ativo acao) =>
                   {
                       acao.AlterarOrdem(++ordem);
                   });
            });

        }

        private void PreencherGrid(IEnumerable<Ativo> ativos)
        {
            dataGridView1.DataSource = ativos.OrderBy(o => o.Ordem).ToList();
            OcultarCampos();
        }

        private async void CadastroAtivo_Load(object sender, EventArgs e)
        {
            _ativos = await _repositorioAtivo.ListarTodosAtivos();
            PreencherGrid(_ativos);
        }

        private async void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                var ativos = _ativos.ToList();
                ativos.Remove(ativos.FirstOrDefault(p => p.Codigo == item.Cells["Codigo"]?.Value?.ToString()));
                await _repositorioAtivo.Adicionar(ativos);
                _ativos = ativos;
            }

            PreencherGrid(_ativos);
        }

        private void OcultarCampos()
        {
            dataGridView1.Columns["Link"].Visible = false;
            dataGridView1.Columns["Verde"].Visible = false;
            dataGridView1.Columns["Vermelho"].Visible = false;
            dataGridView1.Columns["Estatisticas"].Visible = false;
            dataGridView1.Columns["Valor"].Visible = false;
            dataGridView1.Columns["Rentabilidade"].Visible = false;
            dataGridView1.Columns["Rentavel"].Visible = false;
            dataGridView1.Columns["Comprar"].Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            txtCodigo.Text = PegarValorGrid(e.RowIndex, "Codigo");
            numValorbaixa.Text = PegarValorGrid(e.RowIndex, "ValorMinimo");
            numValorDesejado.Text = PegarValorGrid(e.RowIndex, "ValorDesejado");
            numOrdem.Text = PegarValorGrid(e.RowIndex, "Ordem");
            numQuantidadeCotas.Text = PegarValorGrid(e.RowIndex, "QuantidadeCotas");
        }

        private string PegarValorGrid(int index, string campo) => dataGridView1.Rows[index].Cells[campo].Value.ToString();

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ativo = _ativos.ToList().FirstOrDefault(p => p.Codigo == dataGridView1.Rows[e.RowIndex].Cells["Codigo"].Value.ToString());

            var cadastroCompra = new CompraAtivos(ativo.ValoresAtivo);
            cadastroCompra.ShowDialog();
            ativo.ValoresAtivo = cadastroCompra.ValoresAtivo;

            await _repositorioAtivo.Adicionar(_ativos.ToList());

            PreencherGrid(_ativos);
        }
    }
}
