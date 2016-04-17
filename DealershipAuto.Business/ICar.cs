using DealershipAuto.Business.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business
{
	public interface ICar
	{

		ECarTag CarTag { get; set; }

		double Price { get; }

		Engine Engine { get; }
	}
}
