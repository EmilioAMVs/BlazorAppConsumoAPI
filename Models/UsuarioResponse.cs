﻿using System.Text.Json.Serialization;

namespace BlazorAppConsumoAPI.Models
{
    public class UsuarioResponse
    {
        [JsonPropertyName("OBSERVACION")]
        public string Observacion { get; set; }
        public string Emisor { get; set; }
        [JsonPropertyName("PERFIL")]
        public string Perfil { get; set; }
        [JsonPropertyName("NOMBREEMISOR")]
        public string NombreEmisor { get; set; }
    }
}