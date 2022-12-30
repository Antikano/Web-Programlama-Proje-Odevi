using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class KitapApi
    {
        
        [Required]
        public String KitapAdi { get; set; }
        [Required]
        public String KitapTanimi { get; set; }
        [Required]
        public String KitapResmi { get; set; }
        [Required]
        public String YayinEvi { get; set; }
        [Required]
        public int YazarID { get; set; }
    }
}
