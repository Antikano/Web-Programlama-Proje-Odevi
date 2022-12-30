using Entities.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
	[Authorize]
	public class RoleController : Controller
    {
        readonly RoleManager<AppRole> _roleManager;
        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {

            return View();
        }
    
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel model)
        {
            IdentityResult result = await _roleManager.CreateAsync(new AppRole { Name = model.Name });
            if (result.Succeeded)
            {


                return View("RoleList");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View("Index");
        }
        public IActionResult RoleList()
        {
            return View(_roleManager.Roles.ToList());
        }
    }
}
