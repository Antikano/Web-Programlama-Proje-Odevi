using Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.View_Model;

namespace WebApp.Controllers
{
    public class RegisterController : Controller
    {
        readonly UserManager<AppUser> userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
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
        public async Task<IActionResult> Register(UserSignUpViewModel user)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser
                {
                    
                    Email = user.Email,
                    UserName = user.UserName,
                    Name = user.Name,
                    Surname = user.Surname
                };
                

                var result = await userManager.CreateAsync(appUser, user.Password);
                

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(appUser, "Kullanici");
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }


            else
            {
                TempData["msj"] = "lütfen gerekli alanları doldurunuz";
            }


            return View("Index");
        }
    }
}
