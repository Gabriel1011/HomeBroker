using BuscaAcoesF.Formularios.Estilo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeBroker.Telas.Estilo.ComponentesPersonalizados
{
    public class HomeBrokerCheckBox : CheckBox
    {
        public HomeBrokerCheckBox()
        {
            ForeColor = EstiloComponentes.CorLetras;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 11f);
        }
    }
}
