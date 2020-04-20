using BuscaAcoesF.Formularios.Estilo;
using System.Drawing;
using System.Windows.Forms;

namespace BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados
{
    public class HomeBrokerListBox : ListBox
    {
        public HomeBrokerListBox()
        {
            BackColor = EstiloComponentes.CorFundo;
            ForeColor = EstiloComponentes.CorLetras;

            Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0f);

            //DrawMode = DrawMode.OwnerDrawFixed;
            //DrawItem += HomeBrokerListBox_DrawItem;
            //SelectedIndexChanged += HomeBrokerListBox_SelectedIndexChanged;

        }

        private void HomeBrokerListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.Invalidate();
        }

        private void HomeBrokerListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (Items.Count < 1) return;

            try
            {
                int index = e.Index;
                Graphics g = e.Graphics;
                foreach (int selectedIndex in this.SelectedIndices)
                {
                    if (index == selectedIndex)
                    {
                        // Draw the new background colour
                        e.DrawBackground();
                        g.FillRectangle(new SolidBrush(Color.LightGray), e.Bounds);

                        string text = this.Items[index].ToString();
                        g.DrawString(text, e.Font, new SolidBrush(Color.Black), (float)e.Bounds.X, (float)e.Bounds.Y);
                    }
                }

                // Get the item details
                //Font font = this.Font;
                ////Color colour = this.ForeColor;

                if (!SelectedIndices.Contains(index))
                {
                    string texto = this.Items[index].ToString();

                    //// Print the text
                    g.DrawString(texto, e.Font, new SolidBrush(EstiloComponentes.CorLetras), (float)e.Bounds.X, (float)e.Bounds.Y);
                    e.DrawFocusRectangle();
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            
        }
    }
}
