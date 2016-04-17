using DealershipAuto.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{

			IDealership dealership = new Dealership();

			DisplayLines();
			Display("Welcome, chose an option from the following list");
			Display("Press 1 for - Selling car");
			Display("Press 2 for - Buying new standard car");
			Display("Press 3 for - Buying new customized car");
			Display("Press 4 for - Buying second hand car");
			Display("Press anything else to exit");

			string input = Console.ReadLine();
			switch (input)
			{
				case "1": dealership.GetSecondHandCars(); break;
				case "2": dealership.GetStandardCars(); break;
				case "3": dealership.GetCarCustomOptions(); break;
				case "4": dealership.GetSecondHandCars(); break;
				default: break;
			}
		}

		private static void DisplayLines()
		{
			Display("----------------------------------------------");
		}

		private static void Display(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}
