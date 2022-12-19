using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Identity
{
    public class Kullanıcı : IdentityUser<string>
    {
        public string KullanıcıAd { get; set; }
        public string KullanıcıSoyad { get; set; }

    }
}
