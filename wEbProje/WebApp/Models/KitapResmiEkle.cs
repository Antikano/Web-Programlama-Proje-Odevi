using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class KitapResmiEkle
    {
        [Key]
        public int KitapID { get; set; }
        [Required]
        public String KitapAdi { get; set; }
        [Required]
        public String KitapTanimi { get; set; }
        [Required]
        public IFormFile KitapResmi { get; set; }
        [Required]
        public String YayinEvi { get; set; }
        public int YazarID { get; set; }
    }
}
