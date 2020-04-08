using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BuscaAcoesF.Formularios.Estilo
{
    public static class FormatarComponentes
    {
        public static void DarkButton(this Button botao)
        {
            botao.BackColor = Color.FromArgb(43, 39, 39);
            botao.FlatStyle = FlatStyle.Flat;
            botao.ForeColor = Color.White;
        }

        public static void DarkForm(this Form formulario)
        {
            formulario.BackColor = Color.FromArgb(45, 45, 45);
            formulario.ForeColor = Color.White;
        }

        public static void MouseLeaveCloseButton(this Button botao)
        {
            botao.BackColor = Color.FromArgb(43, 39, 39);
        }

        public static void MouseHoverCloseButton(this Button botao)
        {
            botao.BackColor = Color.LightCoral;
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
    }
}
