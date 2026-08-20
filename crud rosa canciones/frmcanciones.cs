using crud_rosa_canciones.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace crud_rosa_canciones
{
    public partial class frmcanciones : Form
    {
        List<cancion> lista = new List<cancion>();
        int idSeleccionado = 0;


        public frmcanciones(Form1 formulario1)
        {
            InitializeComponent();
        }

        private void dgv_canciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void inicializargrid()
        {
            dgv_canciones.DataSource = null;
            dgv_canciones.DataSource = lista;

            dgv_canciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_canciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_canciones.MultiSelect = false;
            dgv_canciones.ReadOnly = true;
        }
        private void refrescar()
        {
            dgv_canciones.DataSource = null;
            dgv_canciones.DataSource = lista;
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                cancion nueva = new cancion(siguienteId(), txb_titulo.Text, txb_artista.Text, int.Parse(txb_año.Text));

                lista.Add(nueva);
                limpiar();
                refrescar();
                MessageBox.Show("Canción agregada correctamente");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar la canción: " + ex.Message);
            }
        }
        private void limpiar()
        {
            dgv_canciones.SelectionChanged -= dgv_canciones_SelectionChanged;

            idSeleccionado = 0;

            txb_titulo.Clear();
            txb_artista.Clear();
            txb_año.Clear();


            dgv_canciones.ClearSelection();
            try
            {
                dgv_canciones.CurrentCell = null;
            }
            catch
            {

            }

            dgv_canciones.SelectionChanged += dgv_canciones_SelectionChanged;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_canciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una canción.");
                return;
            }

            var fila = dgv_canciones.SelectedRows[0];
            var canc = fila.DataBoundItem as cancion;

            if (canc == null)
            {
                MessageBox.Show("No se pudo obtener la canción seleccionada.");
                return;
            }

            if (MessageBox.Show("¿Desea eliminar la canción seleccionada?", "Confirmar", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            lista.Remove(canc);

            limpiar();
            refrescar();

            MessageBox.Show("Canción eliminada correctamente");
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una canción");
                return;
            }


            cancion canc = lista.FirstOrDefault(x => x.Id == idSeleccionado);

            if (canc != null)
            {
                canc.Titulo = txb_titulo.Text;
                canc.Artista = txb_artista.Text;
                canc.Año = int.Parse(txb_año.Text);

                limpiar();

                MessageBox.Show("Canción modificada correctamente");
            }
        }

        private void frmcanciones_Load(object sender, EventArgs e)
        {
            inicializargrid();

        }
        private int siguienteId()
        {
            if (lista.Count == 0)
            {
                return 1;
            }

            return lista.Max(x => x.Id) + 1;
        }

        private void dgv_canciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_canciones.CurrentRow == null)
            {
                return;
            }

            cancion canc = dgv_canciones.CurrentRow.DataBoundItem as cancion;

            if (canc == null)
            {
                return;
            }

            idSeleccionado = canc.Id;

            txb_titulo.Text = canc.Titulo;
            txb_artista.Text = canc.Artista;
            txb_año.Text = canc.Año.ToString();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
