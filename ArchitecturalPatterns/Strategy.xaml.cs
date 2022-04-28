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
using StrategyLibrary;

namespace ArchitecturalPatterns
{
    /// <summary>
    /// Логика взаимодействия для Strategy.xaml
    /// </summary>
    public partial class Strategy : Window
    {
        public Strategy()
        {
            InitializeComponent();
            Car car = new Car("Lexus", "RX", 6500000, new PremiumEquipment());
            info1.Text = car.ToString();
            car.Equipment = new SimpleEquipment();
            info2.Text = car.ToString();
        }
    }
}
