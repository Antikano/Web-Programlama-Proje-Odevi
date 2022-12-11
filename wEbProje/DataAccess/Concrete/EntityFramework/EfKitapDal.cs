using Core.DataAccess;
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
	public class EfKitapDal : EfEntityRepositoryBase<Kitap, KitapContext>, IKitapDal
	{
		public Kitap kitapVeYazar(int id)
		{
			using (KitapContext context = new KitapContext())
			{
				var yazarVeKitap = context.Kitaps.Include(y=>y.Yazar).FirstOrDefault(x => x.KitapID == id);
				return yazarVeKitap;
			}
			
			
		}
	}
}
