using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.ViewComponents
{
    public class AdminYorum : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            YorumManager ym = new YorumManager(new EfYorumDal());
            var allYorums = ym.GetAll();
            allYorums.Reverse();
            return View(allYorums);
        }
    }
}