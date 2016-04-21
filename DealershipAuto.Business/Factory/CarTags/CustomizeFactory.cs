using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;
using DealershipAuto.DealershipAuto.Business.CarTags;
using DealershipAuto.Business.Car_Components;
using DealershipAuto.Business.Car_Components.Engine_Adapter;
using DealershipAuto.Business.Enums;

namespace DealershipAuto.DealershipAuto.Business.Factory.CarTypes
{
	public class CustomizeFactory : CarFactory
	{
		public ICar configurations { get; set; }

		public override Car GetCar()
		{
			Engine e = null;
			switch (configurations.Engine.EngineType)
			{
				case EEngine.Diesel:
					e = new DieselEngine();
					break;
				case EEngine.Petrol:
					e = new PetrolEngine();
					break;
				case EEngine.Gas:
					e = new GasEngine();
					break;
			}
			Car newCar = new CustomizedCar(++_iNumberOfCars)
			{
				Engine = e,
				Model = configurations.Model,
				Base = new Base(),
				Breaks = new Breaks(),
				Electronics = new Electronics(),
				ExhaustingSystem = new ExhaustingSystem(),
			};
			CarEnhancer enh = new CarEnhancer();
			enh.Enhance(newCar, configurations.CarType);
			return newCar;
		}
	}
}
