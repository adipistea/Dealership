using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;
using DealershipAuto.DealershipAuto.Business.CarTags;
using DealershipAuto.Business.Car_Components;
using DealershipAuto.Business.Car_Components.Engine_Adapter;

namespace DealershipAuto.DealershipAuto.Business.Factory.CarTypes
{
	public class BrandNew : CarFactory
	{
		public override Car GetCar()
		{
			return new BrandNewCar(++_iNumberOfCars)//SHOFT + ALT + F10
			{
                Engine = new DieselEngine(),
				Base = new Base(),
				Breaks = new Breaks(),
				Electronics = new Electronics(),
				ExhaustingSystem = new ExhaustingSystem(),
			};
		}
	}
}
