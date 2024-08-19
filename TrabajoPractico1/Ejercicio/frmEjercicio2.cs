using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio
{
    public partial class frmEjercicio2 : Form
    {
        public frmEjercicio2()
        {
            InitializeComponent();
        }

        private void lblIngresoDatos_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbxApellido.Text.Trim().Length != 0 && tbxNombre.Text.Trim().Length != 0)
            {
                lbElementos.Items.Add(tbxApellido.Text + ", " + tbxNombre.Text);
                tbxApellido.Text = "";
                tbxNombre.Text = "";

            }
            else
            {
                MessageBox.Show("Ingrese Nombre y Apellido","Warning");

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
