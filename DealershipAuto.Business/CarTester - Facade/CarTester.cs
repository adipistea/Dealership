using DealershipAuto.Business.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.CarTester___Facade
{
	public class CarTester
	{


		private EngineTester _engineTester;

		public CarTester()
		{
			_engineTester = new EngineTester();
		} 

		public bool IsEligible(ICar car, double amountToBeSoldFor)
		{
			_engineTester.IsEngineGood(car.Engine);

			return false;
		}
	}
}
