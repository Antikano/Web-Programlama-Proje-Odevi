using Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
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
            return View();
        }
        public IActionResult RoleList()
        {
            return View(_roleManager.Roles.ToList());
        }
    }
}
