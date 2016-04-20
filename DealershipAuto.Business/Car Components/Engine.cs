using DealershipAuto.Business.Car_Components;
using DealershipAuto.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Components
{
	public class Engine : IComponent
	{
        public double Overheat { get; set; } //engine overheating > 100 degrees
	}
}
