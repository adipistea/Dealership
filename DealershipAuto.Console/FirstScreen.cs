using DealershipAuto.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI
{
	public class FirstScreen : AbstractScreen
	{
		

		public override void Display_Menu()
		{			
			StartScreen("Welcome, chose an option from the following list");

			Display("Press 1 for - Client");
			Display("Press 2 for - Employee");

			string input = ReadKeyboardCommand();
			switch (input)
			{
				case "1":
					{
						Navigation.GoToScreen<ClientScreen>();
					}
					break;
				case "2":
					{
						Navigation.GoToScreen<EmployeeScreen>();
					}
					break;
				default: break;
			}
		}
	}
}