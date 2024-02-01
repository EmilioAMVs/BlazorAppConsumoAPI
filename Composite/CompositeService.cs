using BlazorAppConsumoAPI.Models;
using BlazorAppConsumoAPI.Pages;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web;

namespace BlazorAppConsumoAPI.Composite
{
    public class CompositeService : IComponent
    {
        private readonly HttpClient _httpClient;

        public CompositeService(IHttpClientFactory clientFactory)
        {
            _httpClient = clientFactory.CreateClient("ApiService");
        }

        public async Task<List<Emisor>> GetEmisores()
        {
            var response = await _httpClient.GetAsync("Varios/GetEmisor");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<Emisor>>();
        }

        public async Task<InfoUsuario> Login(ModeloDeLogin usuarioLogin)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["usuario"] = usuarioLogin.User;
            query["password"] = usuarioLogin.Password;
            var queryString = query.ToString();

            var response = await _httpClient.GetAsync($"Usuarios?{queryString}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var usuarios = JsonConvert.DeserializeObject<List<InfoUsuario>>(content);

            if (usuarios == null || !usuarios.Any())
            {
                throw new InvalidOperationException("Ocurrió un error.");
            }

            return usuarios.FirstOrDefault();
        }
    

    public async Task<List<CentroDeCostos>> GetCentroDeCostos()
    {
        var response = await _httpClient.GetAsync("Varios/CentroCostosSelect");
        response.EnsureSuccessStatusCode();

        var centroDeCostos = await response.Content.ReadFromJsonAsync<List<CentroDeCostos>>();

        if (centroDeCostos == null)
        {
            throw new InvalidOperationException("No se pudieron recibir datos de los centros de costos");
        }

        return centroDeCostos;
    }

    public async Task<CentroDeCostos> PostCentroDeCosto(CentroDeCostos centroDeCosto)
    {
        var url = $"Varios/CentroCostosInsert?codigocentrocostos={centroDeCosto.Codigo}&descripcioncentrocostos={Uri.EscapeDataString(centroDeCosto.NombreCentroCostos)}";

        var response = await _httpClient.PostAsync(url, null);
        response.EnsureSuccessStatusCode();

        var centroCostosRespuesta = await response.Content.ReadFromJsonAsync<List<CentroDeCostos>>();

        return centroCostosRespuesta.FirstOrDefault();
    }
   

    public async Task<List<Empleado>> GetEmpleadosBySucursal(int sucursal)
    {
        try
        {
            var response = await _httpClient.GetAsync($"Varios/TrabajadorSelect?sucursal={sucursal}");
            response.EnsureSuccessStatusCode();

            var trabajadores = await response.Content.ReadFromJsonAsync<List<Empleado>>();

            if (trabajadores == null || !trabajadores.Any())
            {
                throw new InvalidOperationException("No se recibieron datos de trabajadores.");
            }

            return trabajadores;
        }
        catch (Exception ex)
        {
            throw new ApplicationException($"Error al obtener trabajadores de la sucursal {sucursal}: {ex.Message}", ex);
        }
    }
        public async Task<List<MovimientoPlanilla>> GetMovimientosDePlanilla()
        {
            var response = await _httpClient.GetAsync("Varios/MovimientoPlanillaSelect");
            response.EnsureSuccessStatusCode();

            var movimientosPlanilla = await response.Content.ReadFromJsonAsync<List<MovimientoPlanilla>>();

            if (movimientosPlanilla == null)
            {
                throw new InvalidOperationException("No se recibieron datos de movimientos de planilla.");
            }

            return movimientosPlanilla;
        }
    }
    public class CentroCostoStateService
    {
        private List<CentroDeCostos> centroCostos;

        public void SetCentroCostos(List<CentroDeCostos> centros)
        {
            centroCostos = centros;
        }

        public CentroDeCostos GetCentroDeCostoByCodigo(int codigo)
        {
            return centroCostos?.FirstOrDefault(cc => cc.Codigo == codigo);
        }
    }
        public class Emisores
    {
        private readonly IComponent _component;

        public Emisores(IComponent component)
        {
            _component = component;
        }

        public async Task RealizarOperaciones()
        {
            var emisores = await _component.GetEmisores();
            var usuario = await _component.Login(new ModeloDeLogin { User = "user", Password = "password" });
        }
    }
}

