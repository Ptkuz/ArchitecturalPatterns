using SingletonLibrary;
using System;
using System.Windows;

namespace ArchitecturalPatterns
{
    /// <summary>
    /// Логика взаимодействия для Singleton.xaml
    /// </summary>
    public partial class Singleton : Window
    {
        Game game;
        public Singleton()
        {
            InitializeComponent();
            game = new Game();

            var values = Enum.GetValues(typeof(ScreenResolution));

            listResolution.ItemsSource = values;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ScreenResolution screenResolution = (ScreenResolution)listResolution.SelectedItem;
            if (screenResolution != null)
                game.Apply(screenResolution);

            switch (screenResolution)
            {
                case ScreenResolution.HD:
                    MessageBox.Show("Вы выбрали разрешение HD");
                    break;
                case ScreenResolution.FullHD:
                    MessageBox.Show("Вы выбрали разрешение FullHD");
                    break;
                case ScreenResolution.TwoK:
                    MessageBox.Show("Вы выбрали разрешение 2K");
                    break;
                case ScreenResolution.FourK:
                    MessageBox.Show("Вы выбрали разрешение 4K");
                    break;
                default:
                    MessageBox.Show("Вы ничего не выбрали");
                    break;
            }
        }
    }
}
