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
		public int Id { get; set; }
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
			Engine = new Engine();
			Base = new Base();
			Breaks = new Breaks();
			Electronics = new Electronics();
			ExhaustingSystem = new ExhaustingSystem();
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
			foreach (string accessory in Accessories)
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


		public void Use()
		{
			Base.Damage = 25;
			Engine.Overheat = 120;
			ExhaustingSystem.OutNotEliminatedWhileCarStopped = true;

			Random rand = new Random();
			ExhaustingSystem.GasEliminatedWhenCarIsRunning = rand.Next(15, 30);
			Electronics.GasLevel = GetRandomBool();
			Electronics.Radio = GetRandomBool();
			Electronics.Turometer = GetRandomBool();
			Electronics.Vitezometer = GetRandomBool();

			Breaks.BrakeDistance = rand.Next(0, 60);
			Breaks.CableNotBroke = GetRandomBool();
			Breaks.Overheat = rand.Next(50, 150);
		}

		private bool GetRandomBool()
		{
			Random rand = new Random();
			return rand.Next(0, 2) == 0 ? false : true;
		}

		public override bool Equals(object obj)
		{
			ICar car = obj as Car;
			if (car == null)
			{
				return true;
			}
			else
			{
				if (this.Id == car.Id)
				{
					return true;
				}

				return false;
			}
		}
	}
}
