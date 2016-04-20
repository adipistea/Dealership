using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Car_Components
{
	public class ExhaustingSystem : IComponent
	{
		public double GasEliminated { get; set; } //Cantity of gas eliminated

		public bool OutEliminated { get; set; } //If eliminates gas out of the car        
	}
}
