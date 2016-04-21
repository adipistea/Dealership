using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;
using DealershipAuto.Business.Enums;

namespace DealershipAuto.DealershipAuto.Business.Decorator
{
    class BasicCarDecorator : CarDecorator
    {
        public BasicCarDecorator(ICar car, int carid)
			:base(carid)
        {
            _decoratedCar = car;
        }

        public override void Assemble()
        {
            _decoratedCar.SetAccessory("Heating System");
            _decoratedCar.SetAccessory("Assisted Direction");
            _decoratedCar.SetAccessory("ABS");
            _decoratedCar.SetAccessory("Airbags");
            _decoratedCar.SetAccessory("Simple Seat Belts");
            _decoratedCar.SetAccessory("Assistance");
            _decoratedCar.CarType = ECarType.Basic;
        }

        public new ECarType Type()
        {
            return ECarType.Basic;
        }
    }
}
