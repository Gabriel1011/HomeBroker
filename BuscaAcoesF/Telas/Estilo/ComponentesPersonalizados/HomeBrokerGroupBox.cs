using System.Windows.Forms;

namespace BuscaAcoesF.Formularios.Estilo
{
    public class HomeBrokerGroupBox : GroupBox
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, EstiloComponentes.CorLetras, ButtonBorderStyle.Solid);
        }
    }
}
