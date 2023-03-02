using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model;
using RegistryOfPetsGB2023.Model.Data;
using RegistryOfPetsGB2023.Model.Entities.Base;
using RegistryOfPetsGB2023.ViewModels;
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
    public partial class ItemPanelAnimalList : UserControl
    {
        MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
        private IAnimal entity = null;

        public ItemPanelAnimalList()
        {           
            InitializeComponent();
        }                        
                         

        private void Button_Delite(object sender, RoutedEventArgs e)
        {
            mainWindowViewModel.DeliteAnimals(entity);
            entity = null;
            
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
            mainWindowViewModel.StartWindowAdd();
        }
    }
}
