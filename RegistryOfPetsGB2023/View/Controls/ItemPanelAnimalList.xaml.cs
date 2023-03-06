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
        
        
        
        public ItemPanelAnimalList()
        {           
            InitializeComponent();
        }                        
                         

        private void Button_Delite(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            mainWindowViewModel.DeliteAnimals();
            
        }

        private void listCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            if (listCombobox.SelectedItem is Entity entity)
            {
                MainWindowViewModel.entity = entity;
            }
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            mainWindowViewModel.StartWindowAdd();
        }

        private void Button_seeList(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            mainWindowViewModel.StartWindowListComands();
        }
    }
}
