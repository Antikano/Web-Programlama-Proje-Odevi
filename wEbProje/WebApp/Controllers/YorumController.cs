using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class YorumController : Controller
    {
        YorumManager km = new YorumManager(new EfYorumDal());
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Yorumla(Yorum yorum)
        {
            yorum.YorumBaslık = "on";
            yorum.YorumTarih=DateTime.Now;
            
            
                km.Add(yorum);
                
               
                return RedirectToAction("KitapDetaylari", "Kitap",new {id=yorum.KitapID});
            

        }
    }
}
