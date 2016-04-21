using DealershipAuto.Business.Car_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.CarTester___Facade
{
	public class BaseTester
	{

		public TestingResult IsBaseNotDamaged(Base baseOfCar)
		{
			if(baseOfCar.Damage > 13)
			{
				return new TestingResult()
				{
					Passed = false,
					ResultOfInvestigation = "The damage from the base of the car is far too great over 13"
				};
			}
			else
			{
				return new TestingResult()
				{
					Passed = true
				};
			}
		}
	}
}
