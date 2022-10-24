using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Puesto
    {
        public Puesto()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdPuesto { get; set; }
        public string? Puestos { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
