using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfKategoriDal : EfEntityRepositoryBase<Kategori, KitapContext>, IKategoriDal
	{
		public List<Kitap> kategoriVeKitaplar(int id)
		{
			using (KitapContext context = new KitapContext())
			{//context.Kitaps.Include(y => y.Yazar).FirstOrDefault(x => x.KitapID == id)

				var gonder = context.Kategoris.Where(x => x.KategoriID == id).SelectMany(c => c.Kitaplar).ToList(); 
				
				return gonder;
			}
		}
	}
}
