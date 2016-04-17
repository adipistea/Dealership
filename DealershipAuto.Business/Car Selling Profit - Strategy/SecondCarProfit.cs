using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Car_Selling_Profit___Strategy
{
	public class SecondCarProfit : IProfitStrategy
	{
		public double CalculateProfit(ICar car)
		{
			Console.WriteLine("The owner of the second hand car received his money");
			return car.Price / 5;
			//here I should do smth to represent the fact that I am sending part of the money to the owner too
		}
	}
}
