using DealershipAuto.Business.Car_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.CarTester___Facade
{
	public class ExhaustingSystemTester
	{
		public TestingResult IsNotBroken(ExhaustingSystem exhaustingSystem)
		{
			if (!exhaustingSystem.OutNotEliminatedWhileCarStopped)
			{
				return new TestingResult()
				{
					Passed = false,
					ResultOfInvestigation = "Gas is eleiminated while the car is stopped",
				};
			}
			if (exhaustingSystem.GasEliminatedWhenCarIsRunning > 200)
			{
				return new TestingResult()
				{
					Passed = false,
					ResultOfInvestigation = "Gas eleiminated while car is running over 200",
				};
			}

			return new TestingResult()
			{
				Passed = true,
			};
		}
	}
}
