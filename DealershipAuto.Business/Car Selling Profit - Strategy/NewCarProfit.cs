﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Car_Selling_Profit___Strategy
{
	public class NewCarProfit : IProfitStrategy
	{
		public double CalculateProfit(ICar car)
		{
			return car.Price / 2;
		}
	}
}
