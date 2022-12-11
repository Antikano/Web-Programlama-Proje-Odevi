using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Uye : IEntity
	{
		[Key]
		public int UyeID { get; set; }
		public string UyeAd { get; set; }
		public string UyeSoyad { get; set; }
		public string UyeSifre { get; set; }
		public string UyeSifreOnay { get; set; }
		public string UyeMail { get; set; }

	}
}
