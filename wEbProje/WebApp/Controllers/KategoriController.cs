using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
	[Authorize]
	public class KategoriController : Controller
	{
		KategoriManager km = new KategoriManager(new EfKategoriDal());

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult KategorideKitaplar(int id)
		{
			if(id == null)
			{
				return NotFound();
			}
			var kategori = km.Kategoridenkitaplar(id);
			ViewBag.kategori = km.GetById(id).KategoriAd;
			return View(kategori);
		}

		public PartialViewResult KategoriPartial() //bu pek işe yaramadı
		{
			var Kategoriler = km.GetAll();
			return PartialView(Kategoriler);
		}

	}
}
