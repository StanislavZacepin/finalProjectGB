using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Entities;
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
    /// Логика взаимодействия для AddAnimals.xaml
    /// </summary>
    public partial class AddAnimals : Window
    {
        public AddAnimals()
        {
            InitializeComponent();
            ComboBoxAddAnimals.ItemsSource = new IAnimal[] { new Dogs {},
             new Cats {}};
       }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
