using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Data;
using RegistryOfPetsGB2023.Model.Entities;
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
    /// Логика взаимодействия для WindowAddAnimals.xaml
    /// </summary>
    public partial class WindowAddAnimals : Window
    {
        public WindowAddAnimals()
        {
            InitializeComponent();
            ComboBoxAddAnimals.ItemsSource = new IAnimal[] { new Dogs {},
             new Cats {},
             new Hamster{ } };

        }
        private void TextBox_Error(object sender, ValidationErrorEventArgs e)
        {
            MessageBox.Show(e.Error.ErrorContent.ToString());
        }

     
        private void Button_Clancel(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Add(object sender, RoutedEventArgs e)
        {
           
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            mainWindowViewModel.Addanim(TextBoxAddName, ComboBoxAddAnimals, TextBoxAddAge, TextBoxAddDescription);
           
        }


    }
}