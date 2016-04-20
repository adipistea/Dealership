﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Car_Components
{
    public class Breaks : IComponent
    {
        public double Overheat { get; set; }

        public bool CableBroke { get; set; }

        public double BrakeDistance { get; set; }
    }
}
