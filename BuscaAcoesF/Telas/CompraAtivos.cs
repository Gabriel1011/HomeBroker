using BuscaAcoes.Dominio.Auxiliar;
using BuscaAcoes.Dominio.Entidades;
using BuscaAcoesF.Formularios.Estilo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BuscaAcoesF.Formularios
{
    public partial class CompraAtivos : FormBase
    {
        public List<ValorAtivo> ValoresAtivo { get; set; }

        public CompraAtivos(
            ConfiguracoesSistema configuracacoes)
            : base(configuracacoes)
        {
            InitializeComponent();
          
        }
        private void btnCadastrarCompra_Click(object sender, EventArgs e)
        {
            ValoresAtivo.Add(new ValorAtivo(
                Convert.ToInt32(numQuantidade.Text),
                Convert.ToDecimal(numValorPago.Text),
                ValoresAtivo.Count()
                ));
            
            dataGridView1.DataSource = ValoresAtivo.ToList();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                ValoresAtivo.Remove(ValoresAtivo.FirstOrDefault(p=>p.NumeroCompra == (int)row.Cells["NumeroCompra"].Value));
            }

            dataGridView1.DataSource = ValoresAtivo.ToList();
        }

        private void CompraAtivos_Load(object sender, EventArgs e)
        {
            ValoresAtivo = ValoresAtivo ?? new List<ValorAtivo>();
            dataGridView1.DataSource = ValoresAtivo;

            dataGridView1.DarkDataGridView();
            FormatarTela(this);
            dataGridView1.HideColumnDataGrid(new List<string>() { "Valor", "Rentabilidade" });
        }
    }
}
