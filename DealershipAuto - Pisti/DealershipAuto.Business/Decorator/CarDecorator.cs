﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;

namespace DealershipAuto.DealershipAuto.Business.Decorator
{
    public abstract class CarDecorator : ICar
    {
        public Car _decoratedCar;

        public abstract void Assemble();

        public void SetAccessory(string accessory)
        {
            _decoratedCar.SetAccessory(accessory);
        }
    }
}
