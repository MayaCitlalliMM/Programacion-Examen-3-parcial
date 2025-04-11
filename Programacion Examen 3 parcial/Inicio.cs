using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programacion_Examen_3_parcial
{
    public partial class Inicio : Form
    {
        Acciones acc = new Acciones();
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = acc.MostrarJugador();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(tbxEliminar.Text);
            if (acc.EliminarJugador(ID))
                MessageBox.Show("Eliminado con exito");
            else
                MessageBox.Show("fallo al eliminar"); 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbNombre.Text = "";
            txbFecha.Text = "";
            tbxActividad.Text = "";
            tbxColorInterfaz.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txbID.Text);
            DateTime fecha = Convert.ToDateTime(txbFecha.Text);
            bool activo = Convert.ToBoolean(tbxActividad.Text);

            if (acc.AgregarJugador(ID, txbNombre.Text, fecha, activo, tbxColorInterfaz.Text))
            {
                MessageBox.Show("Agregado con exito");

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txbID.Text);
            DateTime fecha = Convert.ToDateTime(txbFecha.Text);
            bool activo = Convert.ToBoolean(tbxActividad.Text);

            if (acc.ActualizarJugador(ID, txbNombre.Text, fecha, activo, tbxColorInterfaz.Text))
            {
                MessageBox.Show("Actualizado con exito");



            }
            else
            {
                MessageBox.Show("fallo en actualizar");
            }
        }
    }
}
