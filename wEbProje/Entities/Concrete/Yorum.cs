using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Yorum:IEntity
	{
		[Key]
		public int YorumID { get; set; }
		public string YorumAd { get; set; }
		public string YorumBaslık { get; set; }
		public string YorumIcerik { get; set; }
		public DateTime YorumTarih { get; set; }
		public Kitap Kitap { get; set; }

	}
}
