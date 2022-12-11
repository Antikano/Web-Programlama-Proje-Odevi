using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKitapService
    {
        List<Kitap> GetAll();
        Kitap GetById(int id);
        void Add(Kitap add);
        void Delete(Kitap delete);
        void Update(Kitap update);

        Kitap YazarVeKitap(int id);

    }
}
