using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DealershipAuto.Business.Enums;
using DealershipAuto.Business.Car_Prototype;
using Newtonsoft.Json;
using DealershipAuto.Business.Car_Components;

namespace DealershipAuto.Business
{
	public class Car : ICar, ICarPrototype
	{
		public int Id { get; private set; }
		public ECarTag CarTag { get; set; }
		public ECarType CarType { get; set; }
		public double Price { get; set; }

		public ECarModel Model { get; set; }

		public bool IsClone { get; set; }


		public Base Base { get; set; }
		public Breaks Breaks { get; set; }
		public Electronics Electronics { get; set; }
		public ExhaustingSystem ExhaustingSystem { get; set; }
		public Engine Engine { get; set; }


		public List<string> Accessories { get; set; }

		public Car(int Id)
		{
			this.Id = Id;
			Accessories = new List<string>();
		}

		public void SetAccessory(string strAccessory)
		{
			Accessories.Add(strAccessory);
		}

		public string ShortSummary()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Model: " + Model + "\n");
			sb.Append("Price: " + Price + "\n");

			return sb.ToString();
		}

		public string LongSummary()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("Model: " + Model + "\n");
			sb.Append("Price: " + Price + "\n");

			sb.Append("Accessories List: ");
			foreach(string accessory in Accessories)
			{
				sb.Append(accessory + "\n");
			}
			return sb.ToString();
		}


		public ICar Clone()
		{
			var json = JsonConvert.SerializeObject(this);

			var obj = JsonConvert.DeserializeObject<Car>(json);
			obj.IsClone = true;
			return obj;
		}



        public ECarType Type()
        {
            return CarType;
        }
    }
}
