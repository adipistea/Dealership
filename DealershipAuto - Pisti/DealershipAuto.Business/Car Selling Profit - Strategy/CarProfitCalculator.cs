using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Car_Selling_Profit___Strategy
{
	public class CarProfitCalculator : Command
	{
		ICar _car;
		IBankAccount _bankAccount;
		double _lastDepositedAmount;

		//TOOD:: maybe use COMMAND design pattern here
		public CarProfitCalculator(IBankAccount bankAccount, ICar car)
		{
			_bankAccount = bankAccount;
			_car = car;
		}


		public override void ProcessProfit(IProfitStrategy profitStrategy)
		{
			double profit = profitStrategy.CalculateProfit(_car);

			_bankAccount.Deposit(profit);
		}

		//temp
		public void Undo()
		{
			_bankAccount.Retrieve(_lastDepositedAmount);
		}
	}

	public abstract class Command
	{
		public abstract void ProcessProfit(IProfitStrategy strategy);
	}
}
