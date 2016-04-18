using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.CarService___Singleton___State
{
    class EmptyState : IServiceState
    {
        Service _service;

        public EmptyState(Service service)
        {
            _service = service;
        }

        public void InsertCar(ICar car)
        {
            _service._car = car;
            _service.SetState(EServiceState.CarInService);
        }

        public void TestCar()
        {
            throw new Exception("Service is empty, no car to test");
        }

        public ICar EjectCar()
        {
            throw new Exception("Service is empty, no car pull out of service");
        }

        public bool GetResultsEligible()
        {
            throw new Exception("Service is empty, no car has been tested, no results to return");
        }

        public string GetResultMessage()
        {
            throw new Exception("Service is empty, no car has been tested, no results to return");
        }
    }
}
