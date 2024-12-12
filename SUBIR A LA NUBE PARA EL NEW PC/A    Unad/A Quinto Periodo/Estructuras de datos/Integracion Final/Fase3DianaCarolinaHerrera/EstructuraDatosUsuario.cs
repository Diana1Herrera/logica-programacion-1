using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3DianaCarolinaHerrera
{
    internal class EstructuraDatosUsuario
    {
        public string tipoId { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string edad { get; set; }
        public string estrato { get; set; }
        public string tipoAtencion { get; set; }
        public string tipoEstructura { get; set; }
        public string reporteDatos { get; set; }
        public string copago { get; set; }
        public DateTime fecha { get; set; }
    }
}
