using BlazorAppConsumoAPI.Models;

namespace BlazorAppConsumoAPI.Composite
{
    public interface IComponent
    {
        Task<List<Emisor>> GetEmisores();
        Task<UsuarioResponse> Login(LoginModel usuarioLogin);
    }
}
