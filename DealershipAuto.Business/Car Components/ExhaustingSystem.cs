using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.Business.Car_Components
{
	public class ExhaustingSystem : IComponent
	{
		public int GasEliminatedWhenCarIsRunning { get; set; } //Cantity of gas eliminated > 200

		public bool OutNotEliminatedWhileCarStopped { get; set; } //If eliminates gas out of the car        
	}
}
