using DealershipAuto.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI
{
	public class BuyingNewCustomizedCarScreen : AbstractScreen
	{
		IDealership _dealership;
		public BuyingNewCustomizedCarScreen(IDealership dealership)
		{
			_dealership = dealership;
		}

		public override void Display_Menu()
		{
			//TODO:: here the custom options should be displayed for the user
		}
	}
}
