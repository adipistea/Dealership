using DealershipAuto.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipAuto.ConsoleUI
{
	public static class Navigation
	{

		static List<AbstractScreen> _screens;

		static Navigation()
		{
			_screens = new List<AbstractScreen>();
		}

		public static void Add(AbstractScreen screen)
		{
			_screens.Add(screen);
		}

		public static void GoToScreen<T>()
			where T : AbstractScreen
		{
			var screen = _screens.FirstOrDefault(n => n.GetType().Equals(typeof(T)));

			if (screen != null)
			{
				screen.Display_Menu();
			}
			else
			{
				throw new Exception("No such screen registered");
			}
		}
	}
}
