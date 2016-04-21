using DealershipAuto.Business.Car_Components;
using DealershipAuto.Business.Car_Prototype;
using DealershipAuto.Business.Enums;

namespace DealershipAuto.Business
{
	public interface ICar : ICarPrototype
	{
		int Id { get; }

		ECarTag CarTag { get; set; }

		ECarType CarType { get; set; }

		double Price { get; set; }

		ECarModel Model { get; set; }

		Base Base { get; set; }
		Breaks Breaks { get; set; }
		Electronics Electronics { get; set; }
		ExhaustingSystem ExhaustingSystem { get; set; }
		Engine Engine { get; set; }

		void SetAccessory(string strAccessory);

		string ShortSummary();

        ECarType Type();

		string LongSummary();

		bool IsClone { get; set; }
	}
}
