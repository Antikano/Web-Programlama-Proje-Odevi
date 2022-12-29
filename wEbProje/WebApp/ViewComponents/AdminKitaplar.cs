using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.ViewComponents
{
    public class AdminKitaplar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            KitapManager km = new KitapManager(new EfKitapDal());
            var kitaplar = km.GetAll();
            return View(kitaplar);
        }
    }
}
