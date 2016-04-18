using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.CarService___Singleton___State
{
    class TestCompletedState : IServiceState
    {
        Service _service;

        public TestCompletedState(Service service)
        {
            _service = service;
        }

        public void InsertCar(ICar car)
        {
            throw new Exception("Service is full, only one car can be in the service at one time");
        }

        public void TestCar()
        {
            throw new Exception("Car has been tested already");
        }

        public ICar EjectCar()
        {
            ICar car = _service._car;
            _service._car = null;
            _service.SetState(EServiceState.Empty);
            return car;
        }

        public bool GetResultsEligible()
        {
            return _service._testResult;
        }

        public string GetResultMessage()
        {
            return _service._testResultMessage;
        }
    }
}
