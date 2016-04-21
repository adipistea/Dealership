using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DealershipAuto.Business;
using DealershipAuto.Business.Enums;

namespace DealershipAuto.DealershipAuto.Business.Decorator
{
	class FamilyCarDecorator : BasicCarDecorator
	{
		public FamilyCarDecorator(Car car, int carId) : base(car, carId) { }

		public override void Assemble()
		{
			base.Assemble();
			_decoratedCar.SetAccessory("Electric Windows");
            _decoratedCar.SetAccessory("Remote Closing");
            _decoratedCar.SetAccessory("Lightning Luggage Carrier");
			_decoratedCar.CarType = ECarType.Family;
		}
	}
}