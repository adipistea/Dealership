using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.CarService___Singleton___State
{
    class CarInServiceState : IServiceState
    {
        Service _service;

        public CarInServiceState(Service service)
        {
            _service = service;
        }

        public void InsertCar(ICar car)
        {
            throw new Exception("Service is full, only one car can be in the service at one time");
        }

        public void TestCar()
        {
            _service.SetState(EServiceState.CarInTest);
            _service.TestCar();
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
            throw new Exception("The car in service has not been tested");
        }

        public string GetResultMessage()
        {
            throw new Exception("The car in service has not been tested");
        }
    }
}
