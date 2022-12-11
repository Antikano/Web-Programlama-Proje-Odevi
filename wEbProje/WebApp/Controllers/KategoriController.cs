using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
	public class KategoriController : Controller
	{
		KategoriManager km = new KategoriManager(new EfKategoriDal());

		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult KategoriPartial() //bu pek işe yaramadı
		{
			var Kategoriler = km.GetAll();
			return PartialView(Kategoriler);
		}

	}
}
