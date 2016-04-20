using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Proxy
{
    public class SafeAccountProxy : IBankAccount
    {
        public class SafeAccountProxy : IBankAccount
        {
            public Account _wrappedAccount;
            public const string pass = "dealership";

            public bool Authentificate()
            {
                Console.Write("Enter password");
                string strPass = Console.ReadLine();
                return strPass.Equals(pass);
            }

            public bool Deposit(double amount)
            {
                if (Authentificate())
                {
                    _wrappedAccount = new Account();
                    return _wrappedAccount.Deposit(amount);
                }

                return false;
            }

            public bool Retrieve(double amount)
            {
                if (Authentificate())
                {
                    _wrappedAccount = new Account();
                    return _wrappedAccount.Retrieve(amount);
                }

                return false;
            }

            public bool Display()
            {
                if (Authentificate())
                {
                    _wrappedAccount = new Account();
                    return _wrappedAccount.Display();
                }

                return false;
            }

        }
    }
}