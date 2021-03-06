﻿using DealershipAuto.Business;
using DealershipAuto.ConsoleUI.Employee_Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			IDealership _dealership = new Dealership();

			Navigation.Add(new FirstScreen());

			//client screens
			Navigation.Add(new ClientScreen());
			Navigation.Add(new BuyingNewCustomizedCarScreen(_dealership));
			Navigation.Add(new BuyingNewStandardCarScreen(_dealership));
			Navigation.Add(new BuyingSecondHandCarScreen(_dealership));
			Navigation.Add(new SellingSecondHandCarMenu(_dealership));

			

			//employee screens
			Navigation.Add(new EmployeeScreen(_dealership));
			Navigation.Add(new BankAccountScreen(_dealership.BankAccount));
			Navigation.Add(new ConfigureStandardCarsScreen(_dealership));

			Navigation.GoToScreen<FirstScreen>();
		}
	}
}
