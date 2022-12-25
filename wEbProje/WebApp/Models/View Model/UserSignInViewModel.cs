using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApp.Models.View_Model
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı Alanının Girilmesi Zorunludur!")]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre Alanının Girilmesi Zorunludur!")]
        public string Password { get; set; }

        
    }
}
