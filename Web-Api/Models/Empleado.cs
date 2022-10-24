using System;
using System.Collections.Generic;

namespace Web_Api.Models
{
    public partial class Empleado
    {
        public int IdEmpleados { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public int? IdPuesto { get; set; }
        public string? Dpi { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaIngresoRegistro { get; set; }

        public virtual Puesto? IdPuestoNavigation { get; set; }
    }
}
