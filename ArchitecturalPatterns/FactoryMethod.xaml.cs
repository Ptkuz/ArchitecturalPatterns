using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using FactoryMethodLibrary;

namespace ArchitecturalPatterns
{
    /// <summary>
    /// Логика взаимодействия для FactoryMethod.xaml
    /// </summary>
    public partial class FactoryMethod : Window
    {
        Company intel, amd;
        ObservableCollection<string> listProcessorIntelCol;
        ObservableCollection<string> listProcessorAMDCol;


        public FactoryMethod()
        {
            InitializeComponent();
            intel = new Intel("Intel");
            amd = new AMD("AMD");
            listProcessorIntelCol = new ObservableCollection<string>();
            listProcessorAMDCol = new ObservableCollection<string>();


        }

        private void buttonIntel_Click(object sender, RoutedEventArgs e)
        {
            Processor processor = intel.Create(processorNameIntel.Text);
            listProcessorIntelCol.Add(processor.Name);
            listProcessorIntel.ItemsSource = listProcessorIntelCol;

            

        }

        private void buttonAMD_Click(object sender, RoutedEventArgs e)
        {
            Processor processor = amd.Create(processorNameAMD.Text);
            listProcessorAMDCol.Add(processor.Name);
            listProcessorAMD.ItemsSource = listProcessorAMDCol;
        }

       
    }
}
