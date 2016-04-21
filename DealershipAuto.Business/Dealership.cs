﻿using DealershipAuto.Business.CarService___Singleton___State;
using DealershipAuto.Business.CarTester___Facade;
using DealershipAuto.Business.Employers___Chain_Of_Responsability;
using DealershipAuto.Business.Enums;
using DealershipAuto.Business.Proxy;
using DealershipAuto.DealershipAuto.Business.Decorator;
using DealershipAuto.DealershipAuto.Business.Factory;
using DealershipAuto.DealershipAuto.Business.Factory.CarTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business
{
	public class Dealership : IDealership
	{
		

		List<BaseEmployee> _employees;
		List<ICar> _secondHandCars;
		List<ICar> _standardCars;
		//TODO standardized cars should be kept in this list also

		public IBankAccount BankAccount { get; private set; }

		public Dealership()
		{
			BankAccount = new SafeAccountProxy();

			_secondHandCars = new List<ICar>();
			_standardCars = new List<ICar>();
			InitStandardCars();

			_employees = new List<BaseEmployee>();

			BaseEmployee manager = new Manager(BankAccount);
			_employees.Add(new Employee(BankAccount) { Successor = manager });
			_employees.Add(manager);
		}


		public void BuyCar(ICar car)
		{
			if(car.CarTag == ECarTag.SecondHand)
			{
				if (_secondHandCars.Contains(car))
				{
					_secondHandCars.Remove(car);
				}
				else
				{
					Console.WriteLine("this car does not exist in our second hand stock");
					return;//or throw exception ??
				}
			}
			
			_employees.FirstOrDefault().HandlePurchase(car);
		}

		//TODO::add here all the enums that represent customization for the car
		public HashSet<Type> GetCarCustomOptions()
		{
			return new HashSet<Type>()
			{
				typeof(EColor),
				typeof(EEngine),
			};
		}

		public List<ICar> GetSecondHandCars()
		{
			return _secondHandCars;
		}

		public List<ICar> GetStandardCars()
		{
			return _standardCars;
		}

		/// <summary>
		/// Sell your car (ICar) through dealership 
		/// </summary>
		/// <param name="car"> The car to be sold. </param>
		/// <returns> true - car passed the CarTester testing ,
		///			  false -  car was rejected by CarTester testing
		/// </returns>
		/// 
		public TestingResult SellSecondHandCar(ICar car, double sellingCost)
		{
			IServiceState service = Service.GetInstance();
			service.InsertCar(car);
			service.TestCar();

			bool isEligible = service.GetResultsEligible();
			if (isEligible)
			{
				car.Price = sellingCost;
				_secondHandCars.Add(car);				
			}

			var result =  new TestingResult()
			{
				Passed = service.GetResultsEligible(),
				ResultOfInvestigation = service.GetResultMessage(),
			};


			service.EjectCar();

			return result;
		}

		private void InitStandardCars()
		{

			ICar car1 = new Car(123958);
			car1.Model = ECarModel.Nissan;
			car1.IsClone = true;
			car1.Price = 50000;
			car1.Electronics.Radio = true;
			car1.Electronics.Vitezometer = true;
			car1.Electronics.Turometer = true;
			
			_standardCars.Add(car1);

			ICar car2 = new Car(16558);
			car2.Model = ECarModel.Mercedes;
			car2.IsClone = true;
			car2.Price = 270000;
			car2.Electronics.Radio = true;
			car2.Electronics.Vitezometer = true;
			car2.Electronics.GasLevel = true;

			_standardCars.Add(car2);

			ICar car3 = new Car(3558);
			car3.Model = ECarModel.Mercedes;
			car3.IsClone = true;
			car3.Price = 80000;
			car1.Electronics.Turometer = true;
			car3.Electronics.Vitezometer = true;
			car3.Electronics.GasLevel = true;

			_standardCars.Add(car3);
		}

		public bool AddStandardCar(ICar car)
		{
			if (_standardCars.Contains(car))
			{
				return false;
			}
			else
			{

				_standardCars.Add(car);
				return true;
			}
		}
	}
}
