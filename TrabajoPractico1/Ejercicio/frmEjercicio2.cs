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
                    lbElementos.Items.Add(tbxApellido.Text.Trim() + ", " + tbxNombre.Text.Trim());
                    LimpiarTextBox();
                }
            }

            else if(tbxNombre.Text.Trim().Length == 0 && tbxApellido.Text.Trim().Length == 0)
            {
                MessageBox.Show("No ingresó Nombre y Apellido", "Warning");
                LimpiarTextBox();
            }
            else if (tbxNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("No ingresó Nombre", "Warning");
                LimpiarTextBox();
            }
            else if (tbxApellido.Text.Trim().Length == 0)
            {
                MessageBox.Show("No ingresó Apellido", "Warning");
                LimpiarTextBox();
            }
           
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            int cantElementos = lbElementos.Items.Count;

            if (cantElementos!=0)
            {
                if (lbElementos.SelectedItem != null)
                {
                    ListBox.SelectedObjectCollection seleccionNombreCompleto = lbElementos.SelectedItems;

                    while (seleccionNombreCompleto.Count > 0)
                    {
                        lbElementos.Items.Remove(seleccionNombreCompleto[0]);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un elemento de la lista", "Warning");
                }

            }
            else
            {
                MessageBox.Show("No hay elementos cargados en la lista", "Warning");
            }

            


        }
    }
}
