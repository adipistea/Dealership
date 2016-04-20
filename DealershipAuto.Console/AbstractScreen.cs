using DealershipAuto.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI
{
	public abstract class AbstractScreen
	{

		public abstract void Display_Menu();
		


		protected void DisplayLines()
		{
			Display("----------------------------------------------");
		}
		protected void ClearDisplay()
		{
			Console.Clear();
		}

		protected void Display(string msg)
		{
			Console.WriteLine(msg);
		}

		protected string ReadKeyboardCommand()
		{
			return Console.ReadLine();
		}

		protected void StartScreen(string msg = null)
		{
			ClearDisplay();
			Display(string.IsNullOrEmpty(msg) ? this.GetType().Name : msg);
			DisplayLines();
		}

		protected void DisplayCars(List<ICar> cars)
		{
			for (int i = 1; i <= cars.Count; i++)
			{
				Display(i + " - " + cars[i-1].ShortSummary());
			}
			int back = cars.Count;
		}

		protected void Display_LongSummaryOfCarAndBuyingScreen(ICar car, Action goBackAction, Action buyCar)
		{

			ClearDisplay();
			Display("Buying Car Last Step:");
			DisplayLines();
			Display("Press 1 to buy");
			Display("Press 2 to go back");

			Display(car.LongSummary());

			string input = ReadKeyboardCommand();
			switch (input)
			{
				case "1": {
						buyCar();
					} break;
				case "2": goBackAction(); break;
				default: break;
			}
		}

		/// <summary>
		/// Goes back to DisplayFirstScreen after 3 seconds
		/// </summary>
		protected void CongratsForBuying_Menu()
		{
			Display("Congrats for taking an excellent Deal! You poor thing!");
			Thread.Sleep(8000);
			Navigation.GoToScreen<FirstScreen>();
		}
	}
}
