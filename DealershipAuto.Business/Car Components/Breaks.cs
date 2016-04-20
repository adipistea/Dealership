using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Car_Components
{
    public class Breaks : IComponents
    {
        private double overheat;
        private bool cableBroke;
        private double brakeDistance;

        public double Overheat { get; set; }

        public bool CableBroke { get; set; }

        public double BrakeDistance { get; set; }
    }
}
