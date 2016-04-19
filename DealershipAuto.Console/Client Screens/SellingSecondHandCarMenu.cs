using DealershipAuto.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI
{
	public class SellingSecondHandCarMenu : AbstractScreen
	{
		IDealership _dealership;
		public SellingSecondHandCarMenu(IDealership dealership)
		{
			_dealership = dealership;
		}

		public override void Display_Menu()
		{
			ClearDisplay();
			Display("In order for the car to be sold through our dealership it needs to pass a service test.");
			Display("1 - If you want to continue"); // Display_SecondHandCar_TestingMenu
			Display("2 - Go back"); //DisplayClientScreen
			
			string input = ReadKeyboardCommand();
			switch (input)
			{
				case "1": Display_SecondHandCar_TestingMenu(); break;
				case "2": Navigation.GoToScreen<ClientScreen>(); break;
				default: break;
			}
		}

		private void Display_SecondHandCar_TestingMenu()
		{
			//TODO:: here the State design pattern should be used
		}
	}
}
