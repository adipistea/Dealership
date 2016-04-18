using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;

namespace DealershipAuto.DealershipAuto.Business.CarTags
{
    class SecondHandCar : Car
    {
        public SecondHandCar(int id) : base(id) { }
    
        public override ECarTag GetCarTag()
        {
            return ECarTag.SecondHand;
        }
    }
}
