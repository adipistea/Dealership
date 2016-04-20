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
		private BreaksTester _breaksTester;
		private ExhaustingSystemTester _exhaustingSystemTester;
		private ElectronicsTester _electronicsTester;
		private BaseTester _baseTester;


		public CarTester()
		{
			_engineTester = new EngineTester();
			_breaksTester = new BreaksTester();
			_electronicsTester = new ElectronicsTester();
			_exhaustingSystemTester = new ExhaustingSystemTester();
			_baseTester = new BaseTester();
		}

		public TestingResult IsEligible(ICar car, double amountToBeSoldFor)
		{

			StringBuilder sb = new StringBuilder();
			int failesTests = 0;

			var engineResult = _engineTester.IsEngineGood(car.Engine);
			if (!engineResult.Passed)
			{
				failesTests++;
				sb.Append(engineResult.ResultOfInvestigation + "\n");
			}

			var breaksResult = _breaksTester.AreBreaksUsable(car.Breaks);
			if (!breaksResult.Passed)
			{
				failesTests++;
				sb.Append(breaksResult.ResultOfInvestigation + "\n");
			}

			var electronicsResult = _electronicsTester.AreElectronicsInGoodShape(car.Electronics);
			if (!electronicsResult.Passed)
			{
				failesTests++;
				sb.Append(electronicsResult.ResultOfInvestigation + "\n");
			}

			var exhaustingTest = _exhaustingSystemTester.IsNotBroken(car.ExhaustingSystem);
			if (!exhaustingTest.Passed)
			{
				failesTests++;
				sb.Append(exhaustingTest.ResultOfInvestigation + " \n");
			}

			var baseTest = _baseTester.IsBaseNotDamaged(car.Base);
			if (!baseTest.Passed)
			{
				failesTests++;
				sb.Append(baseTest.ResultOfInvestigation + " \n");
			}

			if (failesTests >= 3)
			{
				return new TestingResult()
				{
					Passed = false,
					ResultOfInvestigation = sb.ToString(),
				};
			}
			else
			{
				return new TestingResult()
				{
					Passed = true,
				};
			}
		}
	}
}
