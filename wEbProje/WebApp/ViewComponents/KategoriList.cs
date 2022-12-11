using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.ViewComponents
{
	public class KategoriList : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			KategoriManager km = new KategoriManager(new EfKategoriDal());
			var kategoriler = km.GetAll();
			return View(kategoriler);
		}
	}
}
