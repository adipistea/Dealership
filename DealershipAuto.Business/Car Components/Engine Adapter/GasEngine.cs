using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Car_Components.Engine_Adapter
{
    class GasEngine : PetrolEngine
    {
        public void ConsumeGas(Fuel f)
        {
            if (f.EngineType == EngineType)
            {
                Fuel adaptingFuel = new Fuel()
                {
                    Volume = f.Volume,
                    EngineType = Enums.EEngine.Petrol
                };
                ConsumePetrol(adaptingFuel);
                f.Volume = adaptingFuel.Volume;
            }
            else
            {
                throw new Exception(EngineType + " engine can't run on" + f.EngineType);
            }
        }

        public override void ConsumeFuel(Fuel f)
        {
            ConsumeGas(f);
        }
    }
}
