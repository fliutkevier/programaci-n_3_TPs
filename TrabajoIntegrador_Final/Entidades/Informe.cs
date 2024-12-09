using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Informe
    {
        public int ID { get; set; }
        public string Medico { get; set; }
        public string Dni { get; set; }

        public Informe() { }
        public Informe(int idTur, string legajo, string dni, string obs)
        {
            ID = idTur;
            Medico = legajo;
            Dni = dni;
        }
    }
}
