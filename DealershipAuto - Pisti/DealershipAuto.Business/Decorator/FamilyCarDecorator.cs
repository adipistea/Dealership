using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DealershipAuto.Business;
using DealershipAuto.DealershipAuto.Business.Enums

namespace DealershipAuto.DealershipAuto.Business.Decorator
{
    class FamilyCarDecorator : BasicCarDecorator
    {
        public FamilyCarDecorator(Car car) : base(car){ }
 
        public override void Assemble()
        {
            _decoratedCar.SetAccessory("family");
            _decoratedCar.CarType = ECarType.Family;
        }
    }