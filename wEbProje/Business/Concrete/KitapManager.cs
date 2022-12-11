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
    public class KitapManager : IKitapService
    {
        private IKitapDal _kitapDal;

        public KitapManager(IKitapDal kitapDal) 
        { 
            _kitapDal = kitapDal;
        }


        public void Add(Kitap add)
        {
            _kitapDal.Add(add);
        }

        public void Delete(Kitap delete)
        {
            _kitapDal.Delete(delete);
        }

        public List<Kitap> GetAll()
        {
            return _kitapDal.GetList();
        }

        public Kitap GetById(int id)
        {
            return _kitapDal.Get(x=>x.KitapID == id);
        }

        public void Update(Kitap update)
        {
            _kitapDal.Update(update);
        }

		public Kitap YazarVeKitap(int id)
		{
            return _kitapDal.kitapVeYazar(id);
		}
	}
}
