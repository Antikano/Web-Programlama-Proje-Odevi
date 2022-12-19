using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class RegisterController : Controller
    {
        YazarManager ym = new YazarManager(new EfYazarDal());
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Yazar yazar)
        {
            if (ModelState.IsValid)
            {
                ym.Add(yazar);
                return RedirectToAction("Index","Login");
            }

            else
            {
                TempData["msj"] = "lütfen gerekli alanları doldurunuz";
            }


            return View("Index");
        }
    }
}
