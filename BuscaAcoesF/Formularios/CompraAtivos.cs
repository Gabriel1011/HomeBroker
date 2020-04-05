using BuscaAcoes.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BuscaAcoesF.Formularios
{
    public partial class CompraAtivos : Form
    {
        public List<ValorAtivo> ValoresAtivo { get; set; }

        public CompraAtivos(List<ValorAtivo> valoresAtivo)
        {
            InitializeComponent();
            ValoresAtivo = valoresAtivo ?? new List<ValorAtivo>();
            dataGridView1.DataSource = ValoresAtivo;
        }
        private void btnCadastrarCompra_Click(object sender, EventArgs e)
        {
            ValoresAtivo.Add(new ValorAtivo(
                Convert.ToInt32(numQuantidade.Text),
                Convert.ToDecimal(numValorPago.Text),
                ValoresAtivo.Count()
                ));
            
            dataGridView1.DataSource = ValoresAtivo.ToList();
            dataGridView1.Refresh();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                ValoresAtivo.Remove(ValoresAtivo.FirstOrDefault(p=>p.NumeroCompra == (int)row.Cells["NumeroCompra"].Value));
            }
            dataGridView1.DataSource = ValoresAtivo.ToList();
        }
    }
}
