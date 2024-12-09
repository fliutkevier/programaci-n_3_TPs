using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioPaciente
    {
        private DaoPaciente pacienteDao = new DaoPaciente();
        private DaoLocalidad daoLocalidad = new DaoLocalidad();
        private DaoProvincia daoProvincia = new DaoProvincia();
        private DaoNacionalidad daoNacionalidad = new DaoNacionalidad();

        public List<Paciente> ObtenerPacientes()
        {
            List<Paciente> pacientes = pacienteDao.BuscarTodos();
            foreach(Paciente paciente in pacientes)
            {
                paciente.Provincia = daoProvincia.buscarProvincia(paciente.Provincia.Id);
                paciente.Localidad = daoLocalidad.buscarLocalidad(paciente.Localidad.Id);
                paciente.Nacionalidad = daoNacionalidad.buscarNacionalidad(paciente.Nacionalidad.Id);
            }

            return pacientes;
        }
        public bool cargarPaciente(Paciente paciente)
        {
            return pacienteDao.InsertarPaciente(paciente);
        }
        public bool modificar(Paciente paciente)
        {
            //se rellenan los datos faltantes por las dudas
            paciente.Provincia = daoProvincia.buscarProvincia(paciente.Provincia.Id);
            paciente.Localidad = daoLocalidad.buscarLocalidad(paciente.Localidad.Id);
            paciente.Nacionalidad = daoNacionalidad.buscarNacionalidad(paciente.Nacionalidad.Id);

            return pacienteDao.Modificar(paciente);
        }

        public bool bajaLogica(Paciente paciente)
        {
            //no hace falta que se haga la modificacion fuera.
            paciente.Estado = false;
            return pacienteDao.Modificar(paciente);
        }

        public List<Paciente> buscarPacientesXDNI(string dni)
        {
            List<Paciente> pacientes = new List<Paciente>();
            Paciente paciente = pacienteDao.BuscarPaciente(dni);

            if (paciente != null)
            {
                paciente.Provincia = daoProvincia.buscarProvincia(paciente.Provincia.Id);
                paciente.Localidad = daoLocalidad.buscarLocalidad(paciente.Localidad.Id);
                paciente.Nacionalidad = daoNacionalidad.buscarNacionalidad(paciente.Nacionalidad.Id);

                pacientes.Add(paciente);
            }
            return pacientes;
        }

        public Paciente buscarPacienteXDNI(string dni)
        {
            Paciente paciente = pacienteDao.BuscarPaciente(dni);
            
            if (paciente != null)
            {
                paciente.Provincia = daoProvincia.buscarProvincia(paciente.Provincia.Id);
                paciente.Localidad = daoLocalidad.buscarLocalidad(paciente.Localidad.Id);
                paciente.Nacionalidad = daoNacionalidad.buscarNacionalidad(paciente.Nacionalidad.Id);

            }
            return paciente;
            
        }

        

        public List<Paciente>filtrarPacientes(string filtro)
        {
            List<Paciente> pacientes = pacienteDao.FiltrarPacientes(filtro);

            if (pacientes != null)
            {
                foreach (Paciente paciente in pacientes)
                {
                    paciente.Provincia = daoProvincia.buscarProvincia(paciente.Provincia.Id);
                    paciente.Localidad = daoLocalidad.buscarLocalidad(paciente.Localidad.Id);
                    paciente.Nacionalidad = daoNacionalidad.buscarNacionalidad(paciente.Nacionalidad.Id);
                }
            }
            return pacientes;
        }


    }
}
