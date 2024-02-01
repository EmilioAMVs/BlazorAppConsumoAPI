using BlazorAppConsumoAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppConsumoAPI.Observer
{
    public class RolDePagosService : IRolDePagosService
    {
        private List<RolDePagos> listaRolesDePagos = new List<RolDePagos>();

        public event EventHandler<RolDePagosEventArgs> RolDePagosAgregado;

        public async Task<List<RolDePagos>> GetRolesDePagos()
        {
            return listaRolesDePagos;
        }

        public async Task GuardarRolDePagos(RolDePagos rolDePagos)
        {
            listaRolesDePagos.Add(new RolDePagos
            {
                FechaNacimiento = rolDePagos.FechaNacimiento,
                FechaIngreso = rolDePagos.FechaIngreso,
                CuentaBancaria = rolDePagos.CuentaBancaria,
                Banco = rolDePagos.Banco,
                TipoCuenta = rolDePagos.TipoCuenta,
                Bonificacion = rolDePagos.Bonificacion,
                SueldoBase = rolDePagos.SueldoBase,
                FondoReserva = rolDePagos.FondoReserva,
                FormaCalculoDecimo13 = rolDePagos.FormaCalculoDecimo13,
                FormaCalculoDecimo14 = rolDePagos.FormaCalculoDecimo14,
                ReIngreso = rolDePagos.ReIngreso,
                ReIngresoFecha = rolDePagos.ReIngresoFecha
            });
            OnRolDePagosAgregado(new RolDePagosEventArgs(rolDePagos));
        }

        protected virtual void OnRolDePagosAgregado(RolDePagosEventArgs e)
        {
            RolDePagosAgregado?.Invoke(this, e);
        }
    }
}
