using DealershipAuto.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI
{
	public class BuyingSecondHandCarScreen : AbstractScreen
	{
		IDealership _dealership;

		public BuyingSecondHandCarScreen(IDealership dealership)
		{
			_dealership = dealership;
		}

		public override void Display_Menu()
		{

			ClearDisplay(); Display(this.GetType().Name);

			Display("Press number for long description");
			DisplayLines();


			List<ICar> _secondHandCars = _dealership.GetSecondHandCars();

			DisplayCars(_secondHandCars);
			int back = _secondHandCars.Count + 1;
			Display(back + " Go back");

			string input = ReadKeyboardCommand();
			int inputConverted;
			if (!Int32.TryParse(input, out inputConverted) && inputConverted != 0 && inputConverted < _secondHandCars.Count)
			{ return; }

			if (inputConverted == back)
			{

				Navigation.GoToScreen<ClientScreen>();
			}
			else
			{
				Display_LongSummaryOfCarAndBuyingScreen(_secondHandCars[inputConverted - 1], Display_Menu, () =>
				{
					_dealership.BuyCar(_secondHandCars[inputConverted - 1]);
				});
			}
		}
	}
}
