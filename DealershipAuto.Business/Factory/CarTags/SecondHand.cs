﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;
using DealershipAuto.Business.Car_Components;
using DealershipAuto.DealershipAuto.Business.CarTags;

namespace DealershipAuto.DealershipAuto.Business.Factory.CarTypes
{
	public class SecondHand:CarFactory
    {
        public override Car GetCar()
        {
            return new SecondHandCar(++_iNumberOfCars)
			{
				Engine = new Engine(),
				Base = new Base(),
				Breaks = new Breaks(),
				Electronics = new Electronics(),
				ExhaustingSystem = new ExhaustingSystem(),
			};
        }
    }
}