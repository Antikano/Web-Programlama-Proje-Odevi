using DataAccess.Concrete.EntityFramework;
using Entities.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
	[Authorize]
	public class AdminController : Controller
    {
        readonly UserManager<AppUser> userManager;

        public AdminController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var users = userManager.Users;
            return View(users);
        }

        public async Task<IActionResult> UserSil(string UserName)
        {
            AppUser user = new AppUser();
            user = await  userManager.FindByNameAsync(UserName);
            await userManager.DeleteAsync(user);

            return RedirectToAction("Index");
        
        }
    }
}
