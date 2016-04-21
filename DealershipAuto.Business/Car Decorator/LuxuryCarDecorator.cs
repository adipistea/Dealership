using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DealershipAuto.Business;
using DealershipAuto.Business.Enums;

namespace DealershipAuto.DealershipAuto.Business.Decorator
{
	class LuxuryCarDecorator : FamilyCarDecorator
	{
		public LuxuryCarDecorator(Car car, int carId) : base(car, carId) { }


		public override void Assemble()
		{
			base.Assemble();
			_decoratedCar.SetAccessory("AirConditioner");
            _decoratedCar.SetAccessory("Senzors");
            _decoratedCar.SetAccessory("Board Computer");
			_decoratedCar.CarType = ECarType.Luxury;
		}
	}
}