using BuscaAcoesF.Formularios.Estilo;
using System.Windows.Forms;

namespace BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados
{
    public class HomeBrokerLabel : Label
    {
        public HomeBrokerLabel()
        {
            Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0f);
            ForeColor = EstiloComponentes.CorLetras;
        }
    }
}
