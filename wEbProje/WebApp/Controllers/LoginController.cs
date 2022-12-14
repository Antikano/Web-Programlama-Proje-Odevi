using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using WebApp.Models;
using WebApp.Models.View_Model;

namespace WebApp.Controllers
{
	public class LoginController : Controller
	{


        readonly SignInManager<AppUser> signInManager;
        readonly UserManager<AppUser> userManager;

        public LoginController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        public IActionResult Index()
		{
			return View();
		}

        [HttpPost]
        public IActionResult Cookie(string culture)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.Now.AddDays(10) }
            );

            return RedirectToAction("Index");
        }


        [HttpPost]
        public async Task<IActionResult> Login(UserSignInViewModel user)
        {
            if (ModelState.IsValid)
            {
                var neden = userManager.FindByEmailAsync(user.Username);

                if(neden.Result != null)
                {
                    var result = await signInManager.PasswordSignInAsync(neden.Result, user.Password, true, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Kitap");
                    }
                    else
                    {
                        TempData["hata"] = "Böyle bir kullanıcı yok! Lütfen tekrar giriş yapmayı deneyiniz.";
                        return View("Index");
                    }
                }
                else
                {
                    TempData["hata"] = "Böyle bir kullanıcı yok! Lütfen tekrar giriş yapmayı deneyiniz.";
                    return View("Index");
                }
            }
            return View("Index");
           
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return View("Index");
           
        }


    }
}
//else
//{
//    
//    return View("Index");
//}