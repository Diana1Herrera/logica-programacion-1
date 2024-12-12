using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase2DianaHerrera
{
    public class GestionEstudiantes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Instrumento { get; set; }
        public string Genero { get; set; }
        public int NumeroClases { get; set; }

        public double CostoPorClase { get; set; }

        public double costoCurso(int numeroClase,double costoClase) // Metodo
        {
            return numeroClase * costoClase;

        }


    }
}
