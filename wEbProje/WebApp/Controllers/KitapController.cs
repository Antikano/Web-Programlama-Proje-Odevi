using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
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
        [Authorize]
        public IActionResult KitapDetaylari(int id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var kitap = km.YazarVeKitap(id);

            return View(kitap);
        }

        public IActionResult KitapSil (int KitapID)
        {
            Kitap silinecekKitap = new Kitap();
            silinecekKitap = km.GetById(KitapID);
            km.Delete(silinecekKitap);
            return RedirectToAction("Index", "Admin");
        }

        public IActionResult KitapEkle()
        {
            return View();
        }

    }
}
