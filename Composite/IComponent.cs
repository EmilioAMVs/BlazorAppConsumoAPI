using BlazorAppConsumoAPI.Models;
using BlazorAppConsumoAPI.Pages;

namespace BlazorAppConsumoAPI.Composite
{
    public interface IComponent
    {
        Task<List<Emisor>> GetEmisores();
        Task<List<Empleado>> GetEmpleadosBySucursal(int sucursal);
        Task<List<MovimientoPlanilla>> GetMovimientosDePlanilla();
        Task<InfoUsuario> Login(ModeloDeLogin usuarioLogin);
        Task<List<CentroDeCostos>> GetCentroDeCostos();
        Task<CentroDeCostos> PostCentroDeCosto(CentroDeCostos centroDeCostos);
        Task<CentroDeCostos> PutCentroDeCosto(int? codigoCentroDeCostos, string descripcionCentroDeCostos);
        Task<CentroDeCostos> DeleteCentroDeCosto(int codigoCentroDeCostos, string descripcionCentroDeCostos);

    }
}
