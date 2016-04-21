using DealershipAuto.Business;
using DealershipAuto.DealershipAuto.Business.Factory.CarTypes;
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

namespace DealershipAuto.GUI.Windows
{
    /// <summary>
    /// Interaction logic for ClientMenu.xaml
    /// </summary>
    public partial class SellCar : UserControl, ISwitchable
    {
        Car _curentCar;
        public SellCar()
        {
            InitializeComponent();
            State s = State.getInstance();
            CarList.ItemsSource = s.userCarlist;
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
            if (_curentCar == null)
                return;
            State s = State.getInstance();
            var r = s.d.SellSecondHandCar(_curentCar, Convert.ToDouble(CarPrice.Text));
            if(r.Passed)
            {
                Switcher.Switch(new ClientMenu());
                s.userCarlist.Remove(_curentCar);
            }

            else
            {
                MessageBox.Show(r.ResultOfInvestigation);
            }
        }

        private void CarList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;

            if (item != null)
            {
                Car car = item as Car;
                if (car != null)
                {
                    _curentCar = car;
                    CarView.Visibility = System.Windows.Visibility.Visible;

                    InitializeComponent();
                    CarModel.Content = car.Model;
                    CarColor.Content = "Red";
                    CarEngine.Content = car.Engine.EngineType;
                    CarType.Content = car.CarType;
                    CarAccesory.ItemsSource = car.Accessories;
                    CarPrice.Text = car.Price + "";
                }
            }
            
        }

    }
}
