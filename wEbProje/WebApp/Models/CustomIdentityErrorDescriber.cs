using Microsoft.AspNetCore.Identity;

namespace WebApp.Models
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DuplicateUserName(string userName) => new IdentityError { Code = "DuplicateUserName", Description = $"\"{userName}\" kullanıcı adı kullanılmaktadır." };
        public override IdentityError InvalidUserName(string userName) => new IdentityError { Code = "InvalidUserName", Description = "Geçersiz kullanıcı adı." };
        public override IdentityError DuplicateEmail(string email) => new IdentityError { Code = "DuplicateEmail", Description = $"\"{email}\" başka bir kullanıcı tarafından kullanılmaktadır." };
        public override IdentityError InvalidEmail(string email) => new IdentityError { Code = "InvalidEmail", Description = "Geçersiz email." };

        public override IdentityError PasswordRequiresLower() => new IdentityError { Code = "PasswordRequiresLower", Description = "Lütfen şifrenizde küçük harf kullanın" };
        
        public override IdentityError PasswordRequiresUpper() => new IdentityError { Code = "PasswordRequiresUpper", Description = "Lütfen şifrenizde büyük harf kullanın" };
        
    }
}
