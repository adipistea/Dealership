using DealershipAuto.Business.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.CarTester___Facade
{
	public class EngineTester
	{

		public TestingResult IsEngineGood(Engine engine)
		{
			return engine.Overheat > 100 ?
				new TestingResult()
				{
					Passed = false,
					ResultOfInvestigation = "Engine overheats over 100 degrees"
				} : new TestingResult()
				{
					Passed = true
				};
		}
	}
}
