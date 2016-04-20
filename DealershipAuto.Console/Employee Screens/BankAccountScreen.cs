using DealershipAuto.Business;
using DealershipAuto.Business.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI.Employee_Screens
{
	public class BankAccountScreen : AbstractScreen
	{
		IBankAccount _bankAccount;


		public BankAccountScreen(IBankAccount bankAccount)
		{
			_bankAccount = bankAccount;
		}

		public override void Display_Menu()
		{
			StartScreen();
			
			_bankAccount.Display();

			DisplayLines();
			Display("Press 1 - go back");

			string input = ReadKeyboardCommand();
			switch (input)
			{
				case "1": Navigation.GoToScreen<EmployeeScreen>(); break;
				default: break;
			}
		}
	}
}
