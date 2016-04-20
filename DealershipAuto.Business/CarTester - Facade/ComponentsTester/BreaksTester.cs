using DealershipAuto.Business.Car_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.CarTester___Facade
{
	public class BreaksTester
	{
		/// <summary>
		/// Simple logic - If 2 out of 3 fail scenario fails
		/// </summary>
		/// <param name="breaks"></param>
		/// <returns></returns>
		public TestingResult AreBreaksUsable(Breaks breaks)
		{
			int testsFailed = 0;
			StringBuilder sb = new StringBuilder();
			if (!breaks.CableNotBroke)
			{
				testsFailed++;
				sb.Append("Breaks have the cable broken");
			}
			if (breaks.Overheat > 100)
			{
				testsFailed++;
				sb.Append("Breaks are overheating");
			}
			if (breaks.BrakeDistance > 20)
			{
				testsFailed++;
				sb.Append("Breaks have the break distance too big > 20");
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
				};
			}
		}
	}
}
