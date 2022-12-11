using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IYazarService
    {
        List<Yazar> GetAll();
        Yazar GetById(int id);
        void Add(Yazar add);
        void Delete(Yazar delete);
        void Update(Yazar update);
    }
}
