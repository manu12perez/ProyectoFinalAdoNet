using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAdoNet.Models
{
    public class Empleados
    {
        public int id { get; set; }
        public string apellido { get; set; }
        public string oficio { get; set; }
        public int salario { get; set; }
    }
}
