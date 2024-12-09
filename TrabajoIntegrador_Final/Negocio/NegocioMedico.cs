using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioMedico
    {
        private DaoMedico daoMedico = new DaoMedico();
        private DaoLocalidad daoLocalidad = new DaoLocalidad();
        private DaoEspecialidad daoEspecialidad = new DaoEspecialidad();    
        private DaoProvincia daoProvincia = new DaoProvincia();
        private DaoNacionalidad daoNacionalidad = new DaoNacionalidad();

        public bool cargarMedico(Medico medico)
        {
            return daoMedico.insertarMedico(medico);
        }
        public List<Medico> obtenerTodos()
        {

            List<Medico> medicos = daoMedico.buscarTodos();

            foreach (Medico medico in medicos)
            {
                medico.Provincia = daoProvincia.buscarProvincia(medico.Provincia.Id);
                medico.Localidad = daoLocalidad.buscarLocalidad(medico.Localidad.Id);
                medico.Especialidad = daoEspecialidad.buscarEspecialidad(medico.Especialidad.Id);
                medico.Nacionalidad = daoNacionalidad.buscarNacionalidad(medico.Nacionalidad.Id);
            }

            return medicos;
        }

        public bool modificar(Medico medico)
        {
            //se rellenan los datos faltantes por las dudas
            medico.Provincia = daoProvincia.buscarProvincia(medico.Provincia.Id);
            medico.Localidad = daoLocalidad.buscarLocalidad(medico.Localidad.Id);
            medico.Especialidad = daoEspecialidad.buscarEspecialidad(medico.Especialidad.Id);
            medico.Nacionalidad = daoNacionalidad.buscarNacionalidad(medico.Nacionalidad.Id);

            return daoMedico.Modificar(medico);
        }

        public bool bajaLogica(Medico medico)
        {
            //no hace falta que se haga la modificacion fuera.
            medico.Estado = false;
            return daoMedico.Modificar(medico);
        }

        public List<Medico> buscarMedicosPorLegajo(string legajo)
        {
            List<Medico> medicos = new List<Medico>();
            Medico medico = daoMedico.BuscarMedico(legajo.Trim());

            if (medico != null)
            {
                medico.Provincia = daoProvincia.buscarProvincia(medico.Provincia.Id);
                medico.Localidad = daoLocalidad.buscarLocalidad(medico.Localidad.Id);
                medico.Especialidad = daoEspecialidad.buscarEspecialidad(medico.Especialidad.Id);
                medico.Nacionalidad = daoNacionalidad.buscarNacionalidad(medico.Nacionalidad.Id);

                medicos.Add(medico);
            }
            return medicos;
        }
        public Medico buscarMedicoPorLegajo(string legajo)
        {
            Medico medico = daoMedico.BuscarMedico(legajo.Trim());
            if (medico != null) //si no existe carga
            {
                medico.Provincia = daoProvincia.buscarProvincia(medico.Provincia.Id);
                medico.Localidad = daoLocalidad.buscarLocalidad(medico.Localidad.Id);
                medico.Especialidad = daoEspecialidad.buscarEspecialidad(medico.Especialidad.Id);
                medico.Nacionalidad = daoNacionalidad.buscarNacionalidad(medico.Nacionalidad.Id);
            }
            return medico;
        }

        

        public List<Medico> ObtenerXEspecialidad(int idEspecialidad)
        {
            return daoMedico.buscarXEspecialidad(idEspecialidad);
        }

        public List<Medico> filtrarMedicos(string filtro)
        {
            List<Medico> medicos = daoMedico.FiltrarMedicos(filtro);

            if (medicos != null)
            {
                foreach (Medico medico in medicos)
                {
                    medico.Provincia = daoProvincia.buscarProvincia(medico.Provincia.Id);
                    medico.Localidad = daoLocalidad.buscarLocalidad(medico.Localidad.Id);
                    medico.Especialidad = daoEspecialidad.buscarEspecialidad(medico.Especialidad.Id); 
                    medico.Nacionalidad = daoNacionalidad.buscarNacionalidad(medico.Nacionalidad.Id);
                }
            }
            return medicos;
        }



    }
}
