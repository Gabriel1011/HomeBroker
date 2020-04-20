using System.Windows.Forms;

namespace BuscaAcoesF.Telas.Estilo.ComponentesPersonalizados
{
    public class HomeBrokerTextBoxNumber : HomeBrokerTextBox
    {
        public HomeBrokerTextBoxNumber()
        {
            KeyPress += HomeBrokerTextBoxNumber_KeyPress;
        }

        private void HomeBrokerTextBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
