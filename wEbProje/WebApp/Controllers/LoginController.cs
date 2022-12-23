using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
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

        public LoginController(SignInManager<AppUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public IActionResult Index()
		{
			return View();
		}
        [HttpPost]
        public async Task<IActionResult> Login(UserSignInViewModel user)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(user.Username, user.Password, true, false);
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
            return View();
           
        }


    }
}
//else
//{
//    
//    return View("Index");
//}