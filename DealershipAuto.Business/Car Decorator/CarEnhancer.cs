using DealershipAuto.Business.Enums;
using DealershipAuto.DealershipAuto.Business.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business
{
	public class CarEnhancer
	{

		public ICar Enhance(Car car, ECarType type)
		{
			CarDecorator decorator = null;
			switch (type)
			{
				case ECarType.Basic: { decorator = new BasicCarDecorator(car, car.Id); } break;
				case ECarType.Family: { decorator = new FamilyCarDecorator(car, car.Id); } break;
				case ECarType.Luxury: { decorator = new LuxuryCarDecorator(car, car.Id); } break;
			}

			decorator.Assemble();

			return car;
		}
	}
}
