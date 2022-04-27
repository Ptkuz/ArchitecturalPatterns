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
using BuilderLibrary;

namespace ArchitecturalPatterns
{
    /// <summary>
    /// Логика взаимодействия для Builder.xaml
    /// </summary>
    public partial class Builder : Window
    {
        Human human;

        public Builder()
        {
            InitializeComponent();
            human = new Human();
            PCBuilder builder = new GamePC();
            PC gamePC = human.PCbuy(builder);
            strGamePC.Text = gamePC.ToString();


            builder = new OfficePC();
            gamePC = human.PCbuy(builder);
            strOfficePC.Text = gamePC.ToString();

        }
    }
}
