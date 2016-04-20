using DealershipAuto.Business.CarTester___Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business
{
	public interface IDealership
	{
		IBankAccount BankAccount { get; }

		TestingResult SellSecondHandCar(ICar car, double sellingCost);

		
		void BuyCar(ICar car);

		List<ICar> GetStandardCars();		

		List<ICar> GetSecondHandCars();

		HashSet<Type> GetCarCustomOptions();
		//Here Type stands for EColor, EEngine, which in Console UI I will iterate over
	}
}
