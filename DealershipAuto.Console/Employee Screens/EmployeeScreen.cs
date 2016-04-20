using DealershipAuto.Business;
using DealershipAuto.ConsoleUI;
using DealershipAuto.ConsoleUI.Employee_Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI
{
	public class EmployeeScreen : AbstractScreen
	{
		IDealership _dealership;

		public EmployeeScreen(IDealership dealership)
		{
			_dealership = dealership;
		}

		public override void Display_Menu()
		{
			StartScreen("Welcome dear colleague!");

			Display("Press 1 - checking bank account balance");
			Display("Press 2 - add/remove/configure standard cars");
			Display("Press 3 - go back");

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
