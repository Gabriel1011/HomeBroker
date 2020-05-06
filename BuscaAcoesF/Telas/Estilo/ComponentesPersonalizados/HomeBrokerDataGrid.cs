using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaAcoesF.Formularios.Estilo.ComponentesPersonalizados
{
    public class HomeBrokerDataGrid : DataGridView
    {
        public HomeBrokerDataGrid()
        {
            BackgroundColor = Color.Black;
            ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            
            ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11.0F, FontStyle.Bold);
            BackgroundColor = Color.FromArgb(45, 45, 45);

            DefaultCellStyle.SelectionBackColor = Color.LightGray;
            DefaultCellStyle.SelectionForeColor = Color.Black;

            RowHeadersVisible = false;
            EnableHeadersVisualStyles = false;
                       
            foreach (DataGridViewRow row in this.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Black;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
        }
    }
}
