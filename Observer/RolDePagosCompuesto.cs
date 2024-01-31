using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorAppConsumoAPI.Models;
using BlazorAppConsumoAPI.Observer;

namespace BlazorAppConsumoAPI.Observer
{
    public class RolDePagosCompuesto : IRolDePagosComponente
    {
        private List<IRolDePagosComponente> _componentes = new List<IRolDePagosComponente>();

        public async Task MostrarDetalles()
        {
            foreach (var componente in _componentes)
            {
                await componente.MostrarDetalles();
            }
        }

        public void AgregarComponente(IRolDePagosComponente componente)
        {
            _componentes.Add(componente);
        }
    }
}
