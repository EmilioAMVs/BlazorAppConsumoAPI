﻿namespace BlazorAppConsumoAPI.Models
{
    public class Empleado
    {
        public int Id_Trabajador { get; set; }
        public string Tipo_Trabajador { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Nombres { get; set; }
        public string Identificacion { get; set; }
        public string Entidad_Bancaria { get; set; }
        public string Nro_Cuenta_Bancaria {  get; set; }
        public string Direccion { get; set; }
    }
}
