using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApp.Models.View_Model
{
    public class UserSignUpViewModel
    {
        [Required(ErrorMessage = "Ad Alanının Girilmesi Zorunludur!")]

        [Display(Name = "Ad")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Alanının Girilmesi Zorunludur!")]
        [Display(Name = "Soyad")]

        public string Surname { get; set; }

        [Required(ErrorMessage = "Şifre alanının girilmesi zorunludur!")]
        [MaxLength(23, ErrorMessage = "Maximum uzunluk 23 karakterdir!")]
        [MinLength(5, ErrorMessage = "Minimum uzunluk 5 karakterdir!")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor!")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email alanının girilmesi zorunludur!")]
        public string Email { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adı alanının girilmesi zorunludur!")]
        public string UserName { get; set; }
    }
}
