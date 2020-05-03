﻿using System.Windows.Forms;

namespace BuscaAcoesF.Formularios.Estilo
{
    public class HomeBrokerGroupBox : GroupBox
    {
        public HomeBrokerGroupBox()
        {
            ForeColor = EstiloComponentes.CorLetras;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, EstiloComponentes.CorLetras, ButtonBorderStyle.Solid);
        }
    }
}
