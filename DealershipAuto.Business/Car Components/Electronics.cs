﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Car_Components
{
    public class Electronics : IComponent
    {
        public bool Turometer { get; set; } //if turometer works

        public bool Radio { get; set; }  //if radio works

        public bool GasLevel { get; set; } //if the gaslevel is showed

        public bool Vitezometer { get; set; } //if vitezometer works
    }
}
