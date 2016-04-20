using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;
using DealershipAuto.DealershipAuto.Business.CarTags;

namespace DealershipAuto.DealershipAuto.Business.Factory.CarTypes
{
	public class SecondHand:CarFactory
    {
        public override Car GetCar()
        {
            return new SecondHandCar(++ _iNumberOfCars);
        }
    }
}
