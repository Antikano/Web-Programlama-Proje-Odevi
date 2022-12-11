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
    public class KategoriManager : IKategoriService
    {
        private IKategoriDal _kategoriDal;
        public KategoriManager(IKategoriDal kategoriDal) { 
            _kategoriDal= kategoriDal;
        }
        public void Add(Kategori add)
        {
            _kategoriDal.Add(add);
        }

        public void Delete(Kategori delete)
        {
            _kategoriDal.Delete(delete);
        }

        public List<Kategori> GetAll()
        {
            return _kategoriDal.GetList();
        }

        public Kategori GetById(int id)
        {
            return _kategoriDal.Get(x=>x.KategoriID==id);
        }

        public void Update(Kategori update)
        {
            _kategoriDal.Update(update);
        }
    }
}
