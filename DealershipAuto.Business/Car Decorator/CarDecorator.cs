using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;
using DealershipAuto.Business.Enums;

namespace DealershipAuto.DealershipAuto.Business.Decorator
{
    public abstract class CarDecorator : Car
    {
        protected ICar _decoratedCar;

		public CarDecorator(int id) : base(id)
		{

		}

        public abstract void Assemble();

        public void SetAccessory(string accessory)
        {
            _decoratedCar.SetAccessory(accessory);
        }

        public ECarType Type()
        {
            return _decoratedCar.Type();
        }
    }
}
