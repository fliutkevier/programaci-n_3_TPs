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
                foreach (string nombre in lstIzquierda.Items)
                {
                    //valido si son iguales ambas cadenas (la cargada y las existentes) pasasandolas a minusculas.
                    if(string.Equals(nombre.ToLower(), tbxNombre.Text.ToLower()))
                    {
                        MessageBox.Show("Este nombre ya existe en la lista, ingrese otro.", "Warning");
                        existe = true;
                    }
                }

                if(!existe)
                {
                    //si no existe en la lista, lo agrega.
                    lstIzquierda.Items.Add(tbxNombre.Text);
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
            if(lstIzquierda.SelectedItem != null)
            {
                //Si se selecciona un nombre es pasado a la lista derecha y se elimina de la izquierda.
                lstDerecha.Items.Add(lstIzquierda.SelectedItem);
                lstIzquierda.Items.Remove(lstIzquierda.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nombre.", "Warning");
            }
        }

        private void btnPasarTodos_Click(object sender, EventArgs e)
        {
            if(lstIzquierda.Items.Count != 0)
            {
                //si hay nombres cargados, los pasa a la lista derecha.
                foreach (string nombre in lstIzquierda.Items)
                {
                    lstDerecha.Items.Add(nombre);
                }
                lstIzquierda.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay nombres ingresados.", "Warning");
            }
            
        }
    }
}
