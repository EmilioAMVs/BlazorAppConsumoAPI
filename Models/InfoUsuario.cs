using System.Text.Json.Serialization;

namespace BlazorAppConsumoAPI.Models
{
    public class InfoUsuario
    {
        public string Observacion { get; set; }
        public string Emisor { get; set; }
        public string Perfil { get; set; }
        public string NombreEmisor { get; set; }
        public string NombreUsuario { get; set; }
        public string RucUsuario { get; set; }
    }
}
