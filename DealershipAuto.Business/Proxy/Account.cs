using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Proxy
{
    public class Account : IBankAccount
    {
        public static double _balance { get; set; }

        public bool Deposit(double amount)
        {
            _balance += amount;
            return true;
        }

        public bool Retrieve(double amount)
        {
            _balance -= amount;
            return true;
        }

        public void Display()
        {
            Console.WriteLine("Sum of money: {0}", _balance);
        }
    }
}


