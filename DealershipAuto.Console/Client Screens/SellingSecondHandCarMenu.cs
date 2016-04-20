using DealershipAuto.Business;
using DealershipAuto.Business.CarService___Singleton___State;
using DealershipAuto.DealershipAuto.Business.Factory.CarTypes;
using DealershipAuto.Business.Enums;
using System;
using System.Threading;

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
			DisplayLines();
			Display("Please specify a price for your car.");

			
			string input = ReadKeyboardCommand(); int price;
			if (!Int32.TryParse(input, out price))
			{
				return;
			}

			//car testing
			ICar secondHandCar = GetSecondHandCar(price);
			bool result = _dealership.SellSecondHandCar(secondHandCar, price);

			ClearDisplay();

			
			//test result
			if (result)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Display("Thank you your car has been registered.");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Display("Your car is not eligible");
			}

			Display("Have a good day");

			Console.ForegroundColor = ConsoleColor.Cyan;
			Display("You will be redirected to client screen in 7 seconds!");
			for (int i = 7; i >= 1; i--)
			{
				Display(i + " seconds left " + "\n");
				Thread.Sleep(1000);
			}
			Navigation.GoToScreen<ClientScreen>();
		}

		private ICar GetSecondHandCar(int price)
		{
			SecondHand secondHand = new SecondHand();
			ICar car = secondHand.GetCar();
			car.Model = ECarModel.Mercedes;
			//car.Price = price;
			return car;
		}
	}
}
