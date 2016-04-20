using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DealershipAuto.Business;

namespace DealershipAuto.Business.Car_Components
{
    public class Base : IComponent
    {
        private double _baseDamage;
        public double Damage { get; set; } //Percent number of the base damage            
    }
}
