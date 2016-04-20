using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Employers___Chain_Of_Responsability
{
	public class Manager : BaseEmployee
	{
		public Manager(IBankAccount bankAccount) : base(bankAccount)
		{
		}

		public override BaseEmployee Successor { get; set; }

		public override void HandlePurchase(ICar purchase)
		{
			base.CachInProfit(purchase);
			Console.WriteLine(this.GetType().Name + " handled the purchase");
		}
	}
}
