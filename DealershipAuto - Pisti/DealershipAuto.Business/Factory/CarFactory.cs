using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;

namespace DealershipAuto.DealershipAuto.Business.Factory
{
    public abstract class CarFactory
    {
        protected static int _iNumberOfCars = 0;

        public abstract Car GetCar();
    }
}
