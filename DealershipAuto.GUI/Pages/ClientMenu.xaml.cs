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
using DealershipAuto.Business;

namespace DealershipAuto.GUI.Windows
{
    /// <summary>
    /// Interaction logic for ClientMenu.xaml
    /// </summary>
    public partial class ClientMenu : UserControl, ISwitchable
    {
        public ClientMenu()
        {
            InitializeComponent();;
            State s = State.getInstance();
            car_list.ItemsSource = s.userCarlist;
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new BuyCarMenu());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new SellCar());
        }

        private void car_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;
            
            if (item != null)
            {
                Car car = item as Car;
                if (car != null)
                {
                    var modal = new CarWindow(car);
                    modal.ShowDialog();
                }
            }
        }
    }
}
