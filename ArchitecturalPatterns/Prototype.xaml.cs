using PrototypeLibrary;
using System;
using System.Windows;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ArchitecturalPatterns
{
    /// <summary>
    /// Логика взаимодействия для Prototype.xaml
    /// </summary>
    public partial class Prototype : Window
    {

        ITrooper trooper;
        ITrooper cloneTrooper;
        ObservableCollection<ITrooper> trooperList;
        ObservableCollection<ITrooper> darkTrooperList;
        public Prototype()
        {
            InitializeComponent();
            trooperList = new ObservableCollection<ITrooper>();
            darkTrooperList = new ObservableCollection<ITrooper>();
            

        }

        private void btnAddTrooper_Click(object sender, RoutedEventArgs e)
        {
            bool result = Int32.TryParse(idTrooper.Text, out int id);
            if (result)
            {
                trooper = new StormTrooper(id);
                trooperList.Add(trooper);
                listTroopers.ItemsSource = trooperList;
            }
        }

        private void btnCloneTrooper_Click(object sender, RoutedEventArgs e)
        {
            cloneTrooper = trooper.Clone();
            string messageTrooper = trooper.GetInfo();
            trooperList.Add(cloneTrooper);
            listTroopers.ItemsSource = trooperList;
            MessageBox.Show($"{messageTrooper} клонирован");

        }

        private void btnAddDarkTrooper_Click(object sender, RoutedEventArgs e)
        {
            bool result = Int32.TryParse(idDarkTrooper.Text, out int id);
            if (result)
            {
                trooper = new DarkTrooper(id);
                darkTrooperList.Add(trooper);
                listDarkTroopers.ItemsSource=darkTrooperList;
            }
        }

        private void btnCloneDarkTrooper_Click(object sender, RoutedEventArgs e)
        {
            cloneTrooper = trooper.Clone();
            string messageTrooper = trooper.GetInfo();
            darkTrooperList.Add(cloneTrooper);
            listDarkTroopers.ItemsSource = darkTrooperList;
            MessageBox.Show($"{messageTrooper} клонирован");
        }

       

        private void listTroopers_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            object selectedItem = listTroopers.SelectedItem;
            if (selectedItem is StormTrooper)
            {
                btnCloneTrooper.IsEnabled = true;
                trooper = (StormTrooper)selectedItem;
            }
            else
                btnCloneTrooper.IsEnabled=false;

           
        }

        private void listDarkTroopers_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            object selectedItem = listDarkTroopers.SelectedItem;
            if (selectedItem is DarkTrooper)
            {
                btnCloneDarkTrooper.IsEnabled = true;
                trooper = (DarkTrooper)selectedItem;
            }
            else
                btnCloneDarkTrooper.IsEnabled = false;
        }
    }
}
