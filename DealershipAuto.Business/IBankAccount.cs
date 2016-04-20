using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business
{
    public interface IBankAccount
    {

        void Deposit(double money);
        void Retrieve(double _lastDepositedAmount);
        void Display();
    }
}
