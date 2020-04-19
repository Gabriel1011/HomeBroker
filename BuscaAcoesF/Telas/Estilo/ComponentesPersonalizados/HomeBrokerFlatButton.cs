using BuscaAcoesF.Formularios.Estilo;
using System.Windows.Forms;

namespace BuscaAcoesF.Formularios.Estilo
{
    public class HomeBrokerFlatButton : Button
    {
        public HomeBrokerFlatButton()
        {
            FlatStyle = FlatStyle.Flat;
            BackColor = EstiloComponentes.CorFundo;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0f);
        }       
    }
}
