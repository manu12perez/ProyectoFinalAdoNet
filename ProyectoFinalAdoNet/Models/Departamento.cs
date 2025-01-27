using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAdoNet.Models
{
    public class Departamento
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string loc { get; set; }
        public List<Empleados> empleados { get; set; }
    }
}
