using DealershipAuto.Business.Car_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.CarTester___Facade
{
	public class ElectronicsTester
	{

		public TestingResult AreElectronicsInGoodShape(Electronics electronics)
		{
			int testsFailed = 0;
			StringBuilder sb = new StringBuilder();
			if (!electronics.GasLevel)
			{
				testsFailed++;
				sb.Append("Electronics does not display gase level" + "\n");
			}
			if(!electronics.Radio)
			{
				testsFailed++;
				sb.Append("Electronics does not have a radio" + "\n");
			}
			if (!electronics.Turometer)
			{
				testsFailed++;
				sb.Append("Electronics does not have Turometer" + "\n");
			}
			if (!electronics.Vitezometer)
			{
				testsFailed++;
				sb.Append("Electronics does not have Vitezometer" + "\n");
			}

			if( testsFailed >= 2)
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
					ResultOfInvestigation = sb.ToString(),
				};
			}
		}
	}
}
