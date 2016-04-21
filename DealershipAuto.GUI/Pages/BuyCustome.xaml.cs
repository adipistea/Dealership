using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DealershipAuto.Business.Enums;
using DealershipAuto.Business;
using DealershipAuto.DealershipAuto.Business.Factory.CarTypes;
using DealershipAuto.Business.Car_Components;

namespace DealershipAuto.GUI.Windows
{
    /// <summary>
    /// Interaction logic for ClientMenu.xaml
    /// </summary>
    public partial class BuyCustome : UserControl, ISwitchable
    {
        public BuyCustome()
        {
            InitializeComponent();
            CarModel.ItemsSource = Enum.GetNames(typeof(ECarModel))
                            .Select(x => x.ToString())
                            .ToArray();
            CarColor.ItemsSource = Enum.GetNames(typeof(EColor))
                          
                            .Select(x => x.ToString())
                            .ToArray();
            CarEngine.ItemsSource = Enum.GetNames(typeof(EEngine))
                           
                            .Select(x => x.ToString())
                            .ToArray();
            CarType.ItemsSource = Enum.GetNames(typeof(ECarType))
                            
                            .Select(x => x.ToString())
                            .ToArray(); 
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ClientMenu());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new BuyCarMenu());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (CarModel.SelectedIndex == -1
                ||
                CarColor.SelectedIndex == -1
                ||
                CarEngine.SelectedIndex == -1
                ||
                CarType.SelectedIndex == -1
                )
            {
                return;
            }
            else
            {
                State s = State.getInstance();
                CustomizeFactory f = new CustomizeFactory();
                Car c;
                Car config = new Car(-1);
                Engine eng = new Engine();
                eng.EngineType = (EEngine)CarEngine.SelectedIndex;
                config.Engine = eng;
                config.CarType = (ECarType)CarType.SelectedIndex;
                config.Model = (ECarModel)CarModel.SelectedIndex;
                f.configurations = config;
                c = f.GetCar();
                CarPrice.Content = c.Price;
                CarAccesory.ItemsSource = c.Accessories;
                s.d.BuyCar(c);
                s.userCarlist.Add(c);
                Switcher.Switch(new ClientMenu());
            }
        }

        private void CarModel_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CarModel.SelectedIndex == -1
                ||
                CarColor.SelectedIndex == -1
                ||
                CarEngine.SelectedIndex == -1
                ||
                CarType.SelectedIndex == -1
                )
            {
                return;
            }
            else
            {
                State s = State.getInstance();
                CustomizeFactory f = new CustomizeFactory() ;
                Car c;
                Car config = new Car(-1);
                Engine eng = new Engine();
                eng.EngineType = (EEngine)CarEngine.SelectedIndex;
                config.Engine = eng;
                config.CarType = (ECarType)CarType.SelectedIndex;
                config.Model = (ECarModel)CarModel.SelectedIndex;
                f.configurations = config;
                c = f.GetCar();
                CarPrice.Content = c.Price;
                CarAccesory.ItemsSource = c.Accessories;
            }
        }

    }
}
