using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DealershipAuto.Business;
using DealershipAuto.DealershipAuto.Business.Enums;

namespace DealershipAuto.DealershipAuto.Business.Decorator
{
    class LuxuryCarDecorator : FamilyCarDecorator
    {
        public LuxuryCarDecorator(Car car) : base(car){ }


        public override void Assemble()
        {
            _decoratedCar.SetAccessory("luxury");
            _decoratedCar.CarType = ECarType.Luxury;
        }
    }