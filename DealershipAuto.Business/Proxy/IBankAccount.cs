using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business
{
    public interface IBankAccount
    {

		bool Deposit(double money);
		bool Retrieve(double _lastDepositedAmount);
        void Display();
	}
}
