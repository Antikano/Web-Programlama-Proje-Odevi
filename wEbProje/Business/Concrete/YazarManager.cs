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

    public class YazarManager : IYazarService
    {
        private IYazarDal _yazarDal;
        public YazarManager(IYazarDal yazarDal) { 
            _yazarDal= yazarDal;
        }

        public void Add(Yazar add)
        {
            _yazarDal.Add(add);
        }

        public void Delete(Yazar delete)
        {
           _yazarDal.Delete(delete);
        }

        public List<Yazar> GetAll()
        {
           return _yazarDal.GetList();
        }

        public Yazar GetById(int id)
        {
            return _yazarDal.Get(x=>x.YazarID == id);
        }

        public void Update(Yazar update)
        {
            _yazarDal.Update(update);
        }
    }
}
