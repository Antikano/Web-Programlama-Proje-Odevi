using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kategori : IEntity
    {
        [Key]
        public int KategoriID { get; set; }
        public String KategoriAd { get; set; }
        public List<Kitap> Kitaplar { get; set; }
    }
}
