using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
	
	public class KitapController : Controller
    {
        KitapManager km = new KitapManager(new EfKitapDal());

		[Authorize]
		public IActionResult Index()
        {
            var kitaplar = km.GetAll();
            return View(kitaplar);
        }

        public IActionResult KitapDetaylari(int id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var kitap = km.YazarVeKitap(id);

            return View(kitap);
        }
    }
}
