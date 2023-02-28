using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Data;
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
        
        public void LoadedTestData()
        {

        }
        static int index;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(index == null)
                TestData.AnimDelite(index);
        }

        private void DataGrid_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            IAnimal button = (IAnimal)sender;
            index = (int)button.id;
            MessageBox.Show("id"); 
                //IAnimal animal = sender;
                //index = animal.id;
            
        }
    }
}
