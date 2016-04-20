using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Car_Selling_Profit___Strategy
{
	public class CarProfitCalculator
	{
		ICar _car;
		IBankAccount _bankAccount;
		
			
		public CarProfitCalculator(IBankAccount bankAccount, ICar car)
		{
			_bankAccount = bankAccount;
			_car = car;
		}


		public void ProcessProfit(IProfitStrategy profitStrategy)
		{
			double profit = profitStrategy.CalculateProfit(_car);

			_bankAccount.Deposit(profit);
		}
	}
}
