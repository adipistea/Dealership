using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.CarService___Singleton___State
{
    interface IServiceState
    {

        void InsertCar(ICar car);
        void TestCar();
        ICar EjectCar();
        bool GetResultsEligible();
        String GetResultMessage();
    }
}
