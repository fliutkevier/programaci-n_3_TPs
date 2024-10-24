using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_GRUPO_17
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtIdSucursal.Text, out int idSucursal))
            {
                if (VerificarSucursalExistente(idSucursal))  
                {
                    bajaSucursal(idSucursal);  
                    lblMensaje.Text = "La sucursal se ha eliminado con éxito.";
                }
                else
                {
                    
                    lblMensaje.Text = "El ID de sucursal ingresado no existe.";
                }
            }
            else
            {
               
                lblMensaje.Text = "Por favor, ingrese un valor numérico válido.";
            }
        }

        private bool VerificarSucursalExistente(int idSucursal)
        {
            Datos db = new Datos();
            string consultaVerificacion = "SELECT COUNT(*) FROM Sucursal WHERE Id_Sucursal = @ID_Sucursal";
            db.setConsultaDeLectura(consultaVerificacion);
            db.Comando.Parameters.AddWithValue("@ID_Sucursal", idSucursal);
            int count = (int)db.Comando.ExecuteScalar();  
            db.Cerrar();
            return count > 0;  
        }

        private void bajaSucursal(int idSucursal)
        {
            Datos db = new Datos();
            string consultaEliminar = "DELETE FROM Sucursal WHERE Id_Sucursal = @ID_Sucursal";
            db.setConsultaDeLectura(consultaEliminar);
            db.Comando.Parameters.Clear(); 
            db.Comando.Parameters.AddWithValue("@ID_Sucursal", idSucursal);
            db.Comando.ExecuteNonQuery(); 
            db.Cerrar();

        }
    }
}