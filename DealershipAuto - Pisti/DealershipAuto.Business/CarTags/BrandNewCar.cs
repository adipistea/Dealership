using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;

namespace DealershipAuto.DealershipAuto.Business.CarTags
{
    class BrandNewCar : Car
    {
        public BrandNewCar(int id) : base(id) { }

        public override ECarTag GetCarTag()
        {
            return ECarTag.BrandNew;
        }
    }
}
