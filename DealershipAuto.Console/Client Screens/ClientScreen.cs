using DealershipAuto.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI
{
	public class ClientScreen : AbstractScreen
	{
		public override void Display_Menu()
		{
			StartScreen();

			Display("Press 1 - Selling car");
			Display("Press 2 - Buying new standard car");
			Display("Press 3 - Buying new customized car");
			Display("Press 4 - Buying second hand car");
			Display("Press 5 - Go back");
			Display("Press anything else to exit");


			string input = ReadKeyboardCommand();
			switch (input)
			{
				case "1": Navigation.GoToScreen<SellingSecondHandCarMenu>(); break;
				case "2": Navigation.GoToScreen<BuyingNewStandardCarScreen>(); break;
				case "3": Navigation.GoToScreen<BuyingNewCustomizedCarScreen>(); break;
				case "4": Navigation.GoToScreen<BuyingSecondHandCarScreen>(); break;
				case "5": Navigation.GoToScreen<FirstScreen>();break;
				default: break;
			}
		}
	}
}
