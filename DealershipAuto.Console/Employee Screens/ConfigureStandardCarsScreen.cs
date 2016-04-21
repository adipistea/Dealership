using DealershipAuto.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI.Employee_Screens
{
	public class ConfigureStandardCarsScreen : AbstractScreen
	{
		IDealership _dealership;
		public ConfigureStandardCarsScreen(IDealership dealership)
		{
			_dealership = dealership;
		}

		public override void Display_Menu()
		{
			StartScreen();

			Display("Press 1 to add a new prototype");
			Display("Press the number of the prototype to delete it");

			string input = ReadKeyboardCommand();
			switch (input)
			{
				case "1": Navigation.GoToScreen<BankAccountScreen>(); break;
				case "2": Navigation.GoToScreen<ConfigureStandardCarsScreen>(); break;
				case "3": Navigation.GoToScreen<FirstScreen>(); break;
				default: break;
			}
		}
	}
}
