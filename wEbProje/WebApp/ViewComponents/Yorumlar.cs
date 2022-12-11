using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.ViewComponents
{
	public class Yorumlar:ViewComponent
	{
		//sil bunu deneme
		public IViewComponentResult Invoke(int id)
		{
			YorumManager ym = new YorumManager(new EfYorumDal());
			var yorumlar = ym.GetAllByKitapId(id);
			return View(yorumlar);
		}
	}
}
