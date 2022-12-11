using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class YorumManager : IYorumService
	{
		private IYorumDal _yorumDal;
		public YorumManager(IYorumDal yorumDal) { 
			_yorumDal= yorumDal;
		}
		

		public void Add(Yorum add)
		{
			_yorumDal.Add(add);
		}

		public void Delete(Yorum delete)
		{
			_yorumDal.Delete(delete);
		}

		public List<Yorum> GetAll()
		{
			return _yorumDal.GetList();
		}

        public List<Yorum> GetAllByKitapId(int id)
        {
			return _yorumDal.GetList(x=>x.Kitap.KitapID == id);
        }

        public Yorum GetById(int id)
		{
			return _yorumDal.Get(x=>x.YorumID == id);
		}

		public void Update(Yorum update)
		{
			_yorumDal.Update(update);
		}
	}
}
