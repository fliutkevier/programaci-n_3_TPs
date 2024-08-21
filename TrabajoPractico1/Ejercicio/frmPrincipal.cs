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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            frmEjercicio1 frm = new frmEjercicio1();
            frm.ShowDialog();
        }
        
        private void btnEjercicio2_Click(object sender, EventArgs e)
        {
            frmEjercicio2 frm = new frmEjercicio2();
            frm.ShowDialog();
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            frmEjercicio3 frm = new frmEjercicio3();
            frm.ShowDialog();
        }
    }
}
