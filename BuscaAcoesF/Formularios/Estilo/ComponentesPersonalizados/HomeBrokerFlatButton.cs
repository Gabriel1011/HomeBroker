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
        }       
    }
}
