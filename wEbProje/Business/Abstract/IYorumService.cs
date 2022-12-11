using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IYorumService
	{
		List<Yorum> GetAll();
		List<Yorum> GetAllByKitapId(int id);
		Yorum GetById(int id);
		void Add(Yorum add);
		void Delete(Yorum delete);
		void Update(Yorum update);
	}
}
