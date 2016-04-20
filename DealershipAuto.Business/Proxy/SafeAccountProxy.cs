using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Proxy
{
	public class SafeAccountProxy : IBankAccount
	{
		public Account _wrappedAccount;
		public const string pass = "dealership";

		public bool Authentificate()
		{
			Console.WriteLine("Enter password : ");
			string strPass = Console.ReadLine();
			return strPass.Equals(pass);
		}

		public bool Deposit(double amount)
		{
			_wrappedAccount = new Account();
			return _wrappedAccount.Deposit(amount);
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

		public void Display()
		{
			//if (Authentificate())
			//{
			//	_wrappedAccount = new Account();
			//	return _wrappedAccount.Display();
			//}

			//return false;
			if (Authentificate())
			{
				_wrappedAccount = new Account();
				_wrappedAccount.Display();
			}
		}
	}
}