using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApp.Models.View_Model
{
    public class UserSignUpViewModel
    {
        [Required(ErrorMessage = "name_req")]

        [Display(Name = "Ad")]
        public string Name { get; set; }

        [Required(ErrorMessage = "surname_req")]
        [Display(Name = "Soyad")]

        public string Surname { get; set; }

        [Required(ErrorMessage = "pass_req")]
        [MaxLength(23, ErrorMessage = "maxpass")]
        [MinLength(3, ErrorMessage = "minpass")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Required(ErrorMessage ="passag_req")]
        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage = "passAg")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "email_req")]
        public string Email { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "username_req")]
        public string UserName { get; set; }
    }
}
