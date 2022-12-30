using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Yazar : IEntity
    {
        [Key]
        public int YazarID { get; set; }
        
        public string YazarAd { get; set; }
        
        
        public List<Kitap> Kitaplar { get; set; }

    }
}
