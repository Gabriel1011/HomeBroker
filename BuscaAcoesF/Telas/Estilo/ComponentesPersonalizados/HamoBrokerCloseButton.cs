using BuscaAcoesF.Formularios.Estilo;
using System.Windows.Forms;

namespace BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados
{
    public class HamoBrokerCloseButton : PictureBox
    {
        public HamoBrokerCloseButton()
        {
            Name = "btnClose";
            Text = string.Empty;
            Image = System.Drawing.Image.FromFile(@"C:\dev\HomeBroker\BuscaAcoesF\Resource\iconfinder_cross-24_103181_black.png");

            MouseHover += HamoBrokerCloseButton_MouseHover;
            MouseLeave += HamoBrokerCloseButton_MouseLeave;
        }

        private void HamoBrokerCloseButton_MouseLeave(object sender, System.EventArgs e)
        {
            ((PictureBox)sender).MouseLeaveClosePicureBox();
        }

        private void HamoBrokerCloseButton_MouseHover(object sender, System.EventArgs e)
        {
            ((PictureBox)sender).MouseHouverClosePicureBox();
        }
    }
}
