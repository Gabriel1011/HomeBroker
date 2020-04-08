using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BuscaAcoes.Formularios.Estilo
{
    public partial class FormBase : Form
    {
        public Point mouseLocation;
        public FormBase()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FormatarTela(Form tela)
        {
            tela.DarkForm();

            foreach (var button in tela.Controls.OfType<Button>())
            {
                button.DarkButton();
                if(button.Name == "btnClose")
                {
                    button.MouseLeave += Button_MouseLeave;
                    button.MouseHover += Button_MouseHover;
                }
            }
           
            foreach (var gruopBox in tela.Controls.OfType<GroupBox>())
                foreach (var button in gruopBox.Controls.OfType<Button>())
                    button.DarkButton();

            foreach (var dataGridView in tela.Controls.OfType<DataGridView>())
                dataGridView.DarkDataGridView();
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {
            ((Button)sender).MouseHoverCloseButton();
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).MouseLeaveCloseButton();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }

        private void BuscarAcoes_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void BuscarAcoes_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouse = Control.MousePosition;
                mouse.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mouse;
            }
        }
    }
}
