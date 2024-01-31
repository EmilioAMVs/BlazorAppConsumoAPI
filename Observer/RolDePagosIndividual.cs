using System;
using System.Threading.Tasks;
using BlazorAppConsumoAPI.Models;
using BlazorAppConsumoAPI.Observer;

namespace BlazorAppConsumoAPI.Composite
{
    public class RolDePagosIndividual : IRolDePagosComponente
    {
        private readonly DateTime _fechaNacimiento;
        private readonly DateTime _fechaIngreso;
        private readonly string _cuentaBancaria;
        private readonly string _banco;
        private readonly string _tipoCuenta;
        private readonly decimal _bonificacion;
        private readonly decimal _sueldoBase;
        private readonly decimal _fondoReserva;
        private readonly string _formaCalculoDecimo13;
        private readonly string _formaCalculoDecimo14;
        private readonly bool _reIngreso;
        private readonly DateTime _reIngresoFecha;

        public RolDePagosIndividual(DateTime fechaNacimiento, DateTime fechaIngreso, string cuentaBancaria, string banco, string tipoCuenta,
            decimal bonificacion, decimal sueldoBase, decimal fondoReserva, string formaCalculoDecimo13, string formaCalculoDecimo14,
            bool reIngreso, DateTime reIngresoFecha)
        {
            _fechaNacimiento = fechaNacimiento;
            _fechaIngreso = fechaIngreso;
            _cuentaBancaria = cuentaBancaria;
            _banco = banco;
            _tipoCuenta = tipoCuenta;
            _bonificacion = bonificacion;
            _sueldoBase = sueldoBase;
            _fondoReserva = fondoReserva;
            _formaCalculoDecimo13 = formaCalculoDecimo13;
            _formaCalculoDecimo14 = formaCalculoDecimo14;
            _reIngreso = reIngreso;
            _reIngresoFecha = reIngresoFecha;
        }
        public RolDePagosIndividual() { 
        }
        public async Task MostrarDetalles()
        {
            Console.WriteLine($"Fecha de Nacimiento: {_fechaNacimiento}");
            Console.WriteLine($"Fecha de Ingreso: {_fechaIngreso}");
            Console.WriteLine($"Cuenta Bancaria: {_cuentaBancaria}");
            Console.WriteLine($"Banco: {_banco}");
            Console.WriteLine($"Tipo de Cuenta: {_tipoCuenta}");
            Console.WriteLine($"Bonificación: {_bonificacion}");
            Console.WriteLine($"Sueldo Base: {_sueldoBase}");
            Console.WriteLine($"Fondo de Reserva: {_fondoReserva}");
            Console.WriteLine($"Forma de Cálculo Décimo 13: {_formaCalculoDecimo13}");
            Console.WriteLine($"Forma de Cálculo Décimo 14: {_formaCalculoDecimo14}");
            Console.WriteLine($"Re Ingreso: {_reIngreso}");
            if (_reIngreso)
            {
                Console.WriteLine($"Fecha de Re Ingreso: {_reIngresoFecha}");
            }
        }
    }
}
