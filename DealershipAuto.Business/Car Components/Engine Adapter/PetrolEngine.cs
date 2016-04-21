using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Car_Components.Engine_Adapter
{
    class PetrolEngine : Engine
    {
        public PetrolEngine()
        {
            EngineType = Enums.EEngine.Petrol;
        }

        public void ConsumePetrol(Fuel f){
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
            ConsumePetrol(f);
        }
    }
}
