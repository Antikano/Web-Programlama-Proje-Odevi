using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using WebApp.Models;

namespace WebApp.Controllers
{
	public class LoginController : Controller
	{
		YazarManager ym = new YazarManager(new EfYazarDal());

		public IActionResult Index()
		{
			return View();
		}
        [HttpPost]
		public async Task<IActionResult> Login(Yazar yazar)
		{
            var dataValue = ym.GetAll().FirstOrDefault(x => x.YazarMail == yazar.YazarMail
            && x.YazarSifre == yazar.YazarSifre);



            if (dataValue != null)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,yazar.YazarMail),
                new Claim(ClaimTypes.Role,"Admin")
            };
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties();
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity),
                    authProperties);
                return RedirectToAction("Index", "Kitap");
            }

            else
            {
                TempData["hata"] = "Böyle bir kullanıcı yok! Lütfen tekrar giriş yapmayı deneyiniz.";
                return View("Index");
            }
        }
		

	}
}
