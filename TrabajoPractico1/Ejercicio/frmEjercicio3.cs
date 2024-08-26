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
    public partial class frmEjercicio3 : Form
    {
        public frmEjercicio3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (clbProfesion.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe elegir al menos un oficio.", "Warning");
                return;
            }
           
            string elementos = "Usted seleccionó los siguientes elementos:" + "\r\n";
            elementos += "Sexo: " + (string)(rbMasculino.Checked ? "Masculino" : "Femenino")+"\r\n";
            elementos += "Estado civil: " + (string)(rbCasado.Checked ? "Casado" : "Soltero")+"\r\n";
            elementos += "Oficio: " + "\r\n";
            foreach (string oficio in clbProfesion.CheckedItems)
            {
                elementos += "   - " + oficio + "\r\n";
            }
            
            //agregar el resto de elementos seleccionados

            lblElementosSeleccionados.Text = elementos;
        }
    }
}
