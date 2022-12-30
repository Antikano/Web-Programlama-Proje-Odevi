using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApp.Models.View_Model
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "email_req")]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; }

        [Required(ErrorMessage = "pass_req")]
        public string Password { get; set; }

        
    }
}
