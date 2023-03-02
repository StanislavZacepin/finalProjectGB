using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Data;
using RegistryOfPetsGB2023.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace RegistryOfPetsGB2023.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ItemPanelAnimalList.xaml
    /// </summary>
    public partial class ItemPanelAnimalList : UserControl, INotifyPropertyChanged
    {
        public ItemPanelAnimalList()
        {
            Count = +3;
            InitializeComponent();
            this.DataContext = this;

        }

        public int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged("Count");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        static IAnimal entity;
        private static int count;

       

        private void Button_Delite(object sender, RoutedEventArgs e)
        {

            if (entity != null && TestData.animals != null)
            {
                TestData.AnimDelite(entity);
                Count--;
                entity = null;
            }
        }

        private void listCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listCombobox.SelectedItem is IAnimal animal)
            {
                entity = animal;
            }
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            AddAnimals addAnimals = new AddAnimals();
            addAnimals.Show();
        }
    }
}
