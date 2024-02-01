using System.ComponentModel.DataAnnotations;

namespace BlazorAppConsumoAPI.Models
{
        public class ModeloDeLogin
        {
            [Required]
            [StringLength(4)]
            public string User { get; set; }

            [Required]
            public string Password { get; set; }
        }
}
