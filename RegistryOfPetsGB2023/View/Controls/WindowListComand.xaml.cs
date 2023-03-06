using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Entities.Base;
using RegistryOfPetsGB2023.ViewModels;
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

namespace RegistryOfPetsGB2023.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для WindowListComand.xaml
    /// </summary>
    public partial class WindowListComand : Window
    {
       
        public WindowListComand()
        {

            InitializeComponent();
            


        }


        private void Window_Closed(object sender, EventArgs e)
        {
            MainWindowViewModel.Flag = false;
            Close();
        }

        private void listCombobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            if (listCombobox.SelectedItem is ComandAnim entity)
            {
                MainWindowViewModel.comandAnim = entity;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindowViewModel.entity.ComandAnims.Remove(MainWindowViewModel.comandAnim);
        }
    }
}
