﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
	public class KategoriController : Controller
	{
		KategoriManager km = new KategoriManager(new EfKategoriDal());

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult KategorideKitaplar(int id)
		{
			if(id == null)
			{
				return NotFound();
			}
			var kategori = km.Kategoridenkitaplar(id);
			return View(kategori);
		}

		public PartialViewResult KategoriPartial() //bu pek işe yaramadı
		{
			var Kategoriler = km.GetAll();
			return PartialView(Kategoriler);
		}

	}
}
