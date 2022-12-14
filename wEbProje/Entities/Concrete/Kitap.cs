using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kitap : IEntity
    {
        [Key]
        public int KitapID { get; set; }
        [Required]
        public String KitapAdi { get; set; }
        [Required]
        public String KitapTanimi { get; set; }
        [Required]
        public String KitapResmi { get; set; }
        [Required]
        public String YayinEvi { get; set; }
        public int YazarID { get; set; }

        public Yazar Yazar { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public List<Yorum> Yorumlar { get; set; }

    }
}
