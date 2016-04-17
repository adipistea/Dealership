using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business
{
	public class Car : ICar
	{
		public ECarTag CarTag { get; set; }

		public double Price { get; protected set; }
	}
}
