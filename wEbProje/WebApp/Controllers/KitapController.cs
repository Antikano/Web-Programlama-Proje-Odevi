using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
	[Authorize]
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
        [HttpPost]
        public IActionResult KitapEkle(KitapResmiEkle kResim)
        {
            Kitap kitap = new Kitap();
            if (kResim.KitapResmi != null) {
                var extension = Path.GetExtension(kResim.KitapResmi.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Resimler/KitapResimleri/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                kResim.KitapResmi.CopyTo(stream);
                kitap.KitapResmi = "Resimler/KitapResimleri/"+newImageName;
            }
            else
            {
                return View("KitapEkle");
            }
            kitap.KitapTanimi = kResim.KitapTanimi;
            kitap.KitapAdi    = kResim.KitapAdi;
            kitap.YayinEvi    = kResim.YayinEvi;
            kitap.YazarID     = kResim.YazarID;
            km.Add(kitap);
            return RedirectToAction("Index","Admin");
        }

    }
}
