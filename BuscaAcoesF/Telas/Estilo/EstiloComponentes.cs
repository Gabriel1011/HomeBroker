using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BuscaAcoesF.Formularios.Estilo
{
    public static class EstiloComponentes
    {
        public readonly static Color CorLetras = Color.White;
        public readonly static Color CorFundo = Color.FromArgb(45, 45, 45);

        public static void DarkButton(this Button botao)
        {
            botao.BackColor = Color.FromArgb(43, 39, 39);
            botao.FlatStyle = FlatStyle.Flat;
            botao.ForeColor = CorLetras;
        }

        public static void DarkForm(this Form formulario)
        {
            formulario.BackColor = CorFundo;
            formulario.ForeColor = CorLetras;
        }

        public static void MouseLeaveCloseButton(this Button botao)
        {
            botao.BackColor = Color.FromArgb(43, 39, 39);
        }

        public static void MouseLeaveClosePicureBox(this PictureBox pictureBox)
        {
            pictureBox.BackColor = Color.FromArgb(43, 39, 39);
        }

        public static void MouseHoverCloseButton(this Button botao)
        {
            botao.BackColor = Color.Red;
        }

        public static void MouseHouverClosePicureBox(this PictureBox pictureBox)
        {
            pictureBox.BackColor = Color.Red;
        }

        public static void AcaoEmQueda(this DataGridViewRow linha)
        {
            linha.DefaultCellStyle.ForeColor = Color.Red;
        }

        public static void AcaoEmAlta(this DataGridViewRow linha)
        {
            linha.DefaultCellStyle.ForeColor = Color.Green;
        }

        public static void AcaoComValorDeAbertura(this DataGridViewRow linha)
        {
            linha.DefaultCellStyle.ForeColor = Color.Yellow;
        }

        public static void PerdendoDinheiro(this DataGridViewCell celula)
        {
            celula.Style.BackColor = Color.LightPink;
        }
        public static void GanhandoDinheiro(this DataGridViewCell celula)
        {
            celula.Style.BackColor = Color.LightGreen;
        }

        public static void HoraDeComprar(this DataGridViewRow linha)
        {
            linha.DefaultCellStyle.BackColor = Color.LightGreen;
        }

        public static void DarkDataGridView(this DataGridView grid)
        {
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11.0F, FontStyle.Bold);
            grid.BackgroundColor = Color.FromArgb(45, 45, 45);

            grid.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;

            grid.RowHeadersVisible = false;

            grid.EnableHeadersVisualStyles = false;

            foreach (DataGridViewRow row in grid.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Black;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
        }

        public static void HideColumnDataGrid(this DataGridView grid, string columnName) =>
            grid.Columns[columnName].Visible = false;

        public static void HideColumnDataGrid(this DataGridView grid, IList<string> columnsName) 
        {
            foreach (var columnName in columnsName)
                grid.Columns[columnName].Visible = false;
        }

        public static void DarkContextMenuStrip(this ContextMenuStrip menu)
        {
            menu.BackColor = Color.FromArgb(45, 45, 45);
            menu.ForeColor = Color.LightGray;
        }

        public static void LightContextMenuStrip(this ContextMenuStrip menu)
        {
            menu.BackColor = Color.LightGray;
            menu.ForeColor = Color.Black;
        }

        public static void RedForeColor(this Label label) => label.ForeColor = Color.Red;

        public static void GreenForeColor(this Label label) => label.ForeColor = Color.Green;

    }
}
