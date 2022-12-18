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
        [Required(ErrorMessage = "Ad alanının girilmesi zorunludur!")]
        [MaxLength(100,ErrorMessage ="Maximum uzunluk 100 karakterdir!")]
        public string YazarAd { get; set; }
        [Required(ErrorMessage = "Tanım alanının girilmesi zorunludur!")]
        [MaxLength(200, ErrorMessage = "Maximum uzunluk 200 karakterdir!")]
        public string YazarTanım { get; set; }
        [Required(ErrorMessage = "Email alanının girilmesi zorunludur!")]
        [EmailAddress(ErrorMessage ="Email formatında giriş yapmalısınız!")]
        [MaxLength(100,ErrorMessage = "Maximum uzunluk 100 karakterdir!")]
        public string YazarMail { get; set; }
        [Required(ErrorMessage ="Şifre alanının girilmesi zorunludur!")]
        [MaxLength(20,ErrorMessage ="Maximum uzunluk 20 karakterdir!")]
        [MinLength(2,ErrorMessage ="Minimum uzunluk 2 karakterdir!")]
        public string YazarSifre { get; set; }
        public string YazarResim { get; set; }
        public List<Kitap> Kitaplar { get; set; }

    }
}
