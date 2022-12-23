using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class ServiceRegistration
    {
        public static void Register(this IServiceCollection services) {
            //services.AddIdentity<Kullanıcı, Role>().AddEntityFrameworkStores<KitapContext>(); 
            // add migration ve update database yapman lazım **** gencay proje kampı, 38.video, 15:30
        }
    }
}
