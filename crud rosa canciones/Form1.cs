
namespace crud_rosa_canciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form formulario = Application.OpenForms["frmcanciones"];

            if (formulario != null)
            {
                formulario.Activate();
                return;
            }

            frmcanciones frmcanciones = new frmcanciones(this);
            frmcanciones.Show();
        }
    }
}
