using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;

namespace DealershipAuto.DealershipAuto.Business.Factory.CarTypes
{
    class SecondHand:CarFactory
    {
        public override Car GetCar()
        {
            return new SecondHandCar(++ _iNumberOfCars);
        }
    }
}
