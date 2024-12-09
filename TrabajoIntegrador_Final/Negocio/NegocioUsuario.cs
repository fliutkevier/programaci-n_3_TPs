using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioUsuario
    {
        private DaoUsuario usuarioDAO = new DaoUsuario();

        public Usuario AutenticarUsuario(string nombreUsuario, string contrasenia)
        {
            return usuarioDAO.ValidarUsuario(nombreUsuario, contrasenia);
        }

        public List<Usuario> obtenerUsuarios()
        {

            List<Usuario> usuarios = usuarioDAO.obtenerUsuarios();
            return usuarios;
        }

        public void crearUsuario(Usuario usuario)
        {
            usuarioDAO.crearUsuario(usuario);
        }

        public List<Usuario> buscarUsuarioNombre(string nombreUsuario)
        { 
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = usuarioDAO.encontrarUsuario(nombreUsuario);

            if (usuario != null)
            {
                usuarios.Add(usuario);
            }

            return usuarios;
        }
    }
}
