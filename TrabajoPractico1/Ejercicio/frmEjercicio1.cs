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
    public partial class frmEjercicio1 : Form
    {
        public frmEjercicio1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            //validación si esta vació el campo de texto.
            if(tbxNombre.Text.Trim() != string.Empty)
            {
                
                //reviso los elementos de la lista izquierda.
                foreach (string nombre in lbIzquierda.Items)
                {
                    //valido que no haya espacios antes o despues para no repetir el nombre.
                    nombre.Trim();
                    nombre.TrimStart();
                    //valido si son iguales ambas cadenas (la cargada y las existentes) pasasandolas a minusculas.
                    if (string.Equals(nombre.ToLower(), tbxNombre.Text.ToLower().Trim()))
                    {
                        MessageBox.Show("Este nombre ya existe en la lista, ingrese otro.", "Warning");
                        existe = true;
                    }
                }
                foreach (string nombre in lbDerecha.Items)
                {
                    //valido que no haya espacios antes o despues para no repetir el nombre.
                    nombre.Trim();
                    nombre.TrimStart();
                    //valido si son iguales ambas cadenas (la cargada y las existentes) pasasandolas a minusculas.
                    if (string.Equals(nombre.ToLower(), tbxNombre.Text.ToLower().Trim()))
                    {
                        MessageBox.Show("Este nombre ya existe en la lista, ingrese otro.", "Warning");
                        existe = true;
                    }
                }

                if (!existe)
                {
                    //si no existe en la lista, lo agrega.
                    lbIzquierda.Items.Add(tbxNombre.Text.Trim());
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nombre.", "Warning");
            }
            tbxNombre.Text = string.Empty;
        }

        private void btnPasarNombre_Click(object sender, EventArgs e)
        {
            int cantNombres=lbIzquierda.Items.Count;

            if (cantNombres != 0)
            {
                if (lbIzquierda.SelectedItem != null)
                {
                    ListBox.SelectedObjectCollection seleccionIzquierda = lbIzquierda.SelectedItems;

                    while (seleccionIzquierda.Count > 0)
                    {
                        lbDerecha.Items.Add(lbIzquierda.SelectedItem);
                        lbIzquierda.Items.Remove(seleccionIzquierda[0]);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un nombre.", "Warning");
                }

            }
            else 
            {
                MessageBox.Show("No hay nombres cargados en la lista", "Warning");
            }

            
        }

        private void btnPasarTodos_Click(object sender, EventArgs e)
        {
            if(lbIzquierda.Items.Count != 0)
            {
                //si hay nombres cargados, los pasa a la lista derecha.
                foreach (string nombre in lbIzquierda.Items)
                {
                    lbDerecha.Items.Add(nombre);
                }
                lbIzquierda.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay nombres ingresados.", "Warning");
            }
            
        }
    }
}
