using BlazorAppConsumoAPI.Models;
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

        public async Task<UsuarioResponse> Login(LoginModel usuarioLogin)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query["usuario"] = usuarioLogin.Usuario;
            query["password"] = usuarioLogin.Password;
            var queryString = query.ToString();

            var response = await _httpClient.GetAsync($"Usuarios?{queryString}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var usuarios = JsonConvert.DeserializeObject<List<UsuarioResponse>>(content);

            if (usuarios == null || !usuarios.Any())
            {
                throw new InvalidOperationException("Ocurrió un error.");
            }

            return usuarios.FirstOrDefault();
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
            var usuario = await _component.Login(new LoginModel { Usuario = "user", Password = "password" });
        }
    }
}

