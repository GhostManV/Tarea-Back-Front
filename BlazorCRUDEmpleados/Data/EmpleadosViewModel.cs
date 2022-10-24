namespace BlazorCRUDEmpleados.Data
{
    public class EmpleadosViewModel
    {
        public int IdEmpleados { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public int? IdPuesto { get; set; }
        public string? Puesto { get; set; }
        public string? Dpi { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaIngresoRegistro { get; set; }
    }
}
