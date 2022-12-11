using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKategoriService
    {
            List<Kategori> GetAll();
            Kategori GetById(int id);
            void Add(Kategori add);
            void Delete(Kategori delete);
            void Update(Kategori update);
        
    }
}
