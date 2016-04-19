using DealershipAuto.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI
{
	public class BuyingNewStandardCarScreen : AbstractScreen
	{
		IDealership _dealership;
		public BuyingNewStandardCarScreen(IDealership dealership)
		{
			_dealership = dealership;
		}

		public override void Display_Menu()
		{
			StartScreen();

			DisplayListOfStandardCars();
		}

		private void DisplayListOfStandardCars()
		{
			StartScreen();

			Display("Press number for long description");
			DisplayLines();

			var cars = _dealership.GetStandardCars();
			DisplayCars(cars);
			int back = cars.Count + 1;
			Display(back + " Go back");

			string input = ReadKeyboardCommand();
			int inputConverted;
			if (!Int32.TryParse(input, out inputConverted) && inputConverted != 0 && inputConverted < cars.Count)
			{ return; }

			if (inputConverted == back)
			{

				Navigation.GoToScreen<ClientScreen>();
			}
			else
			{
				Display_LongSummaryOfCarAndBuyingScreen(cars[inputConverted - 1], Display_Menu, () =>
				{
					_dealership.BuyCar(cars[inputConverted - 1]);
				});
			}
		}
	}
}
