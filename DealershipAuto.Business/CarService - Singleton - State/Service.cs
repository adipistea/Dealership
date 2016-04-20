using DealershipAuto.Business.CarTester___Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.CarService___Singleton___State
{
    public class Service : IServiceState
    {
        private static Service _instance = null;
        private IServiceState _state;
        private Dictionary<EServiceState, IServiceState> _states;
        public ICar _car { get; set; }
        public bool _testResult { set; get; }
        public String _testResultMessage { get; set; }
        public CarTester _tester;


        private Service()
        {
            _states = new Dictionary<EServiceState, IServiceState>();
            _states.Add(EServiceState.Empty, new EmptyState(this));
            _states.Add(EServiceState.CarInService, new CarInServiceState(this));
            _states.Add(EServiceState.CarInTest, new CarInTestState(this));
            _states.Add(EServiceState.TestCompleted, new TestCompletedState(this));
            _state = _states[EServiceState.Empty];
            _tester = new CarTester();
        }

        public static Service GetInstance()
        {
            if (_instance == null)
                _instance = new Service();
            return _instance;
        }

        public void SetState(EServiceState state)
        {
            _state = _states[state];
        }

        public void TestCar()
        {
            _state.TestCar();
        }

        public void InsertCar(ICar car)
        {
            _state.InsertCar(car);
        }

        public ICar EjectCar()
        {
            return _state.EjectCar();
        }

        public bool GetResultsEligible()
        {
            return _state.GetResultsEligible();
        }

        public string GetResultMessage()
        {
            return _state.GetResultMessage();
        }
    }
}
