using DealershipAuto.Business.Car_Selling_Profit___Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business
{
	public abstract class BaseEmployee
	{

		public BaseEmployee()
		{
			//TODO:: initialize BankAccount
		}

		protected IBankAccount BankAccount { get; set; }

		public abstract BaseEmployee Successor { get; set; }

		public abstract void HandlePurchase(ICar purchase);

		public void CachInProfit(ICar car)
		{
			CarProfitCalculator calculator = new CarProfitCalculator(BankAccount, car);
			if (car.CarTag == ECarTag.SecondHand)
			{
				calculator.ProcessProfit(new SecondCarProfit());
			}
			else
			{
				calculator.ProcessProfit(new NewCarProfit());
			}
		}
	}
}
