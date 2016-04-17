using DealershipAuto.Business.Components;
using DealershipAuto.Business.Employers___Chain_Of_Responsability;
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
		public Dealership()
		{
			_secondHandCars = new List<ICar>();
			_standardCars = new List<ICar>();
			_employees = new List<BaseEmployee>();

			BaseEmployee manager = new Manager();
			_employees.Add(new Employee() { Successor = manager });
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
		public bool SellSecondHandCar(ICar car, double sellingCost)
		{
			bool eligible = new CarTester___Facade.CarTester().IsEligible(car, sellingCost);
			if (eligible)
			{
				//car.Price = sellingCost;
				_secondHandCars.Add(car);
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
