
using Microsoft.AspNetCore.Components;

namespace BlazorAppConsumoAPI.Models
{
    public class RolDePagos
    {
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string CuentaBancaria { get; set; }
        public string Banco { get; set; }
        public string TipoCuenta { get; set; }
        public decimal Bonificacion { get; set; }
        public decimal SueldoBase { get; set; }
        public decimal FondoReserva { get; set; }
        public string FormaCalculoDecimo13 { get; set; }
        public string FormaCalculoDecimo14 { get; set; }
        public bool ReIngreso { get; set; }
        public DateTime ReIngresoFecha { get; set; }

    }
}
