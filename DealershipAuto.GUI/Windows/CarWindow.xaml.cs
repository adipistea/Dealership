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
using System.Windows.Shapes;
using DealershipAuto.Business;

namespace DealershipAuto.GUI.Windows
{
    /// <summary>
    /// Interaction logic for CarWindow.xaml
    /// </summary>
    public partial class CarWindow : Window
    {
        Car _car;
        public CarWindow(Car car )
        {
            _car = car;
            InitializeComponent();
            CarId.Content = car.Id;
            CarModel.Content = car.Model;
            CarColor.Content = "Red";
            CarEngine.Content = car.Engine.EngineType;
            CarType.Content = car.CarType;
            CarTag.Content = car.CarTag;
            CarAccesory.ItemsSource = car.Accessories;
            
        }
    }
}
