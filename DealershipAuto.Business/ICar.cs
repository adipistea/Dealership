using DealershipAuto.Business.Car_Prototype;
using DealershipAuto.Business.Components;
using DealershipAuto.Business.Enums;

namespace DealershipAuto.Business
{
	public interface ICar : ICarPrototype
	{

		ECarTag CarTag { get; set; }

		ECarType CarType { get; set; }

		double Price { get; set; }

		ECarModel Model { get; set; }

		Engine Engine { get; }

		void SetAccessory(string strAccessory);

		string ShortSummary();

		string LongSummary();

		bool IsClone { get; set; }
	}
}
