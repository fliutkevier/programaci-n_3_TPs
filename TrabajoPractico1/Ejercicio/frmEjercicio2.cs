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

        private void LimpiarTextBox()
        {
            tbxApellido.Text = "";
            tbxNombre.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbxApellido.Text.Trim().Length != 0 && tbxNombre.Text.Trim().Length != 0)
            { bool existe = false;
                string nombreCompleto = tbxApellido.Text.Trim() + ", " + tbxNombre.Text.Trim();
                foreach (string nombre in lbElementos.Items)
                {
                    nombre.Trim();
                    nombre.TrimStart();
                    if (string.Equals(nombre.ToUpper(), nombreCompleto.ToUpper()))
                    {
                        MessageBox.Show("Nombre ya existente, ingrese otro", "Warning");
                        LimpiarTextBox();
                        existe = true;
                    }
                }
                if (!existe)
                {
                    lbElementos.Items.Add(tbxApellido.Text + ", " + tbxNombre.Text);
                    LimpiarTextBox();
                }
            }
            
            else
            {
                MessageBox.Show("Ingrese Nombre y Apellido","Warning");
                LimpiarTextBox();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lbElementos.SelectedItem != null)
            {
                lbElementos.Items.Remove(lbElementos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debe seleccionar el nombre a borrar", "Warning");
            }
        }
    }
}
