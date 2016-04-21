

using DealershipAuto.Business.Car_Components.Engine_Adapter;
namespace DealershipAuto.Business.Car_Components
{
	public abstract class Engine : IComponent
	{
        public double Overheat { get; set; } //engine overheating > 100 degrees
        public Enums.EEngine EngineType { get; set; }
        public abstract void ConsumeFuel(Fuel f);
	}
}
