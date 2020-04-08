using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Formularios.Estilo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BuscaAcoes.Formularios
{
    public partial class CompraAtivos : FormBase
    {
        public List<ValorAtivo> ValoresAtivo { get; set; }

        public CompraAtivos(List<ValorAtivo> valoresAtivo)
        {
            InitializeComponent();
            ValoresAtivo = valoresAtivo ?? new List<ValorAtivo>();
            dataGridView1.DataSource = ValoresAtivo;

            dataGridView1.DarkDataGridView();
            FormatarTela(this);
        }
        private void btnCadastrarCompra_Click(object sender, EventArgs e)
        {
            ValoresAtivo.Add(new ValorAtivo(
                Convert.ToInt32(numQuantidade.Text),
                Convert.ToDecimal(numValorPago.Text),
                ValoresAtivo.Count()
                ));
            
            dataGridView1.DataSource = ValoresAtivo.ToList();

            dataGridView1.DarkDataGridView();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                ValoresAtivo.Remove(ValoresAtivo.FirstOrDefault(p=>p.NumeroCompra == (int)row.Cells["NumeroCompra"].Value));
            }

            dataGridView1.DataSource = ValoresAtivo.ToList();

            dataGridView1.DarkDataGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
