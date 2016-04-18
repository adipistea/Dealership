using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.DealershipAuto.Business.Factory;
using DealershipAuto.DealershipAuto.Business.Enums;

namespace DealershipAuto.Business
{
    public class Car : ICar
    {
        public int Id { get; private set; }
        public ECarTag CarTag { get; set; }
        public ECarType CarType { get; set; }

        public double Price { get; protected set; }

        public Car(int Id)
        {
            this.Id = Id;
            // Accessories = new List<string>();
        }

        public void SetAccessory(string strAccessory)
        {
            Accessories.Add(strAccessory);
        }
    }
}
