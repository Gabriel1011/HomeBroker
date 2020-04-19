using BuscaAcoes.Dominio.Auxiliar;
using HomeBroker.Telas;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BuscaAcoesF.Formularios.Estilo
{
    public partial class FormBase : Form
    {
        private readonly ConfiguracoesSistema _configuracacoes;
        public Point _mouseLocation;
        Screen _tela = Screen.AllScreens.FirstOrDefault(p => !p.Primary) ?? Screen.AllScreens.FirstOrDefault(p => p.Primary);

        public FormBase(ConfiguracoesSistema configuracacoes)
        {
            InitializeComponent();
            this.DarkForm();
            _configuracacoes = configuracacoes;
            //lblTitle.Text += " - " + _configuracacoes.Config.NomeUsuario;
        }

        public FormBase()
        {
            InitializeComponent();
            this.DarkForm();
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
                if (button.Name == "btnClose")
                {
                    button.MouseLeave += Button_MouseLeave;
                    button.MouseHover += Button_MouseHover;
                    button.Click += Button_Click;
                }
            }

            foreach (var gruopBox in tela.Controls.OfType<GroupBox>())
                foreach (var button in gruopBox.Controls.OfType<Button>())
                    button.DarkButton();

            foreach (var gruopBox in tela.Controls.OfType<GroupBox>())
                foreach (var dataGridView in gruopBox.Controls.OfType<DataGridView>())
                    dataGridView.DarkDataGridView();

            foreach (var dataGridView in tela.Controls.OfType<DataGridView>())
                dataGridView.DarkDataGridView();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            this.Close();
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
            _mouseLocation = new Point(-e.X, -e.Y);
        }

        private void BuscarAcoes_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouse = Control.MousePosition;
                mouse.Offset(_mouseLocation.X, _mouseLocation.Y);
                Location = mouse;
            }
        }

        private void lblTitle_MouseClick(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                ApresentarMenu(e, menu);
            }
        }

        private void ApresentarMenu(MouseEventArgs e, ContextMenuStrip menu)
        {
            menu.Items.Add("Abrir XP Investimento").Name = "XP";
            menu.Items.Add("Abrir Configurações").Name = "CONFIG";
            menu.Show(lblTitle, new Point(e.X, e.Y));
            menu.ItemClicked += AbrirSite;
        }

        private void AbrirSite(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "XP":
                    System.Diagnostics.Process.Start($@"https://portal.xpi.com.br/");
                    break;
                case "CONFIG":
                    CompositionRoot.Resolve<Configuracoes>().ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void FormBase_Paint(object sender, PaintEventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, EstiloComponentes.CorLetras, ButtonBorderStyle.Solid);
        }

        private void lblTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            _tela = Screen.AllScreens.Where(p => p != _tela).FirstOrDefault();

            if (this.Location.Y > 0)
                this.Location = new Point(this.Location.X, this.Location.Y - 1080);
            else
                this.Location = new Point(this.Location.X, this.Location.Y + 1080);
        }
    }
}
