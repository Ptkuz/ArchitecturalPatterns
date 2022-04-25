using AbstractFactoryLibrary;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ArchitecturalPatterns
{
    /// <summary>
    /// Логика взаимодействия для AbstactFactoryMethod.xaml
    /// </summary>
    public partial class AbstactFactoryMethod : Window
    {
        Shepard shepard, shepard1;
        ObservableCollection<string> actions = new ObservableCollection<string>();
        ObservableCollection<string> actions1 = new ObservableCollection<string>();

        public AbstactFactoryMethod()
        {
            InitializeComponent();
            shepard = new Shepard(new SoldierFactory());
            shepard1 = new Shepard(new BioticFactory());



        }

        private void buttonHit_Click(object sender, RoutedEventArgs e)
        {
            
            shepard.Hit(out string message);
            actions.Add(message);
            listActions.ItemsSource = actions;
        }

        private void buttonUse_Click(object sender, RoutedEventArgs e)
        {
            shepard.Use(out string message);
            actions.Add(message);
            listActions.ItemsSource = actions;
        }

        private void buttonHit1_Click(object sender, RoutedEventArgs e)
        {
            shepard1.Hit(out string message);
            actions1.Add(message);
            listActions1.ItemsSource = actions1;
        }

        private void buttonUse1_Click(object sender, RoutedEventArgs e)
        {
            shepard1.Use(out string message);
            actions1.Add(message);
            listActions1.ItemsSource = actions1;
        }
    }
}
