using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Examen_3_parcial
{
    public partial class Form1 : Form
    {
        Usuarios u = new Usuarios();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txbUsuario.Text;
            string Password = txbContraseña.Text;

            var lista = u.ObtenerUsuario();
            var valida = lista.FirstOrDefault(u => u.NombreUsuario == user && u.Contrasenia == Password);
            if (valida != null)
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("ERROR en algo");
            }
        }
    }
}
