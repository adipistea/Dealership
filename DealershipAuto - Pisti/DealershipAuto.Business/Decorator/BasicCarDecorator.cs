using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;
using DealershipAuto.DealershipAuto.Business.Enums;

namespace DealershipAuto.DealershipAuto.Business.Decorator
{
    class BasicCarDecorator : CarDecorator
    {
        public BasicCarDecorator(Car car)
        {
            _decoratedCar = car;
        }

        public override void Assemble()
        {
            _decoratedCar.SetAccessory("basic");
            _decoratedCar.CarType = ECarType.Basic;
        }
    }
}
