using BlazorAppConsumoAPI.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppConsumoAPI.Observer
{
    public interface IRolDePagosService
    {
        event EventHandler<RolDePagosEventArgs> RolDePagosAgregado;

        Task<List<RolDePagos>> GetRolesDePagos();
        Task GuardarRolDePagos(RolDePagos rolDePagos);
    }

    public class RolDePagosEventArgs : EventArgs
    {
        public RolDePagos RolDePagos { get; }

        public RolDePagosEventArgs(RolDePagos rolDePagos)
        {
            RolDePagos = rolDePagos;
        }
    }
}
