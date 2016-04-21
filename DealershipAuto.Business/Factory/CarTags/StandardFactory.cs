using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;
using DealershipAuto.DealershipAuto.Business.CarTags;
using DealershipAuto.Business.Car_Components;
using DealershipAuto.Business.Car_Components.Engine_Adapter;
using DealershipAuto.Business.Car_Prototype;
using DealershipAuto.Business.Enums;

namespace DealershipAuto.DealershipAuto.Business.Factory.CarTypes
{
	public class StandardFactory : CarFactory
	{
        ICar car {get; set;}

		public override Car GetCar()
		{
            Car newCar = (Car) car.Clone();
            newCar.Id = ++_iNumberOfCars;
			newCar.CarTag = ECarTag.Standard;
            return newCar;
		}
	}
}
