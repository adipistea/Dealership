using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;

namespace DealershipAuto.GUI
{
    
    public class State
    {
        private State()
        {
            d = new Dealership();
            userCarlist = new List<Car>();
        }
        public static State getInstance()
        {
            if (_instance == null)
                _instance = new State();
            return _instance;
        }
        public Dealership d { get; set; }
        public List<Car> userCarlist { get; set; }
        static State _instance;
    }
}
