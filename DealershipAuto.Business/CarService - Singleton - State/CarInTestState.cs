using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.CarService___Singleton___State
{
	class CarInTestState : IServiceState
	{
		Service _service;

		public CarInTestState(Service service)
		{
			_service = service;
		}

		public void InsertCar(ICar car)
		{
			throw new Exception("Service is full, only one car can be in the service at one time");
		}

		public void TestCar()
		{
			var testResult = _service._tester.IsEligible(_service._car, 0);

			_service._testResult = testResult.Passed;

			_service._testResultMessage = testResult.ResultOfInvestigation;

			_service.SetState(EServiceState.TestCompleted);
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
			throw new Exception("Car is undergoing tests");
		}

		public string GetResultMessage()
		{
			throw new Exception("Car is undergoing tests");
		}
	}
}
