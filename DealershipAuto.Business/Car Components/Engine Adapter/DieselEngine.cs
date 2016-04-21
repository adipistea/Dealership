using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Car_Components.Engine_Adapter
{
    public class DieselEngine : Engine
    {
        public DieselEngine()
        {
            EngineType = Enums.EEngine.Diesel;
        }

        public void ConsumeDiesel(Fuel f){
            if(f.EngineType == EngineType)
            {
                f.Volume = 0;
            }
            else
            {
                throw new Exception(EngineType + " engine can't run on" + f.EngineType);
            }
        }

        public override void ConsumeFuel(Fuel f)
        {
            ConsumeDiesel(f);
        }
    }
}
