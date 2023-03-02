using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Data;
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

        private int count;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxAddName.Text) || string.IsNullOrEmpty(ComboBoxAddAnimals.Text) || string.IsNullOrEmpty(TextBoxAddAge.Text) || string.IsNullOrEmpty(TextBoxAddDescription.Text))
            {
                MessageBox.Show("Не все поля заполенны");
            }
            else
            {
                switch (ComboBoxAddAnimals.SelectedItem)
                {
                    case Cats:
                        TestData.animals.Add(new Cats { id = TestData.id, Name = TextBoxAddName.Text, Age = int.Parse(TextBoxAddAge.Text), Description = TextBoxAddDescription.Text });
                        break;
                    case Dogs:
                        TestData.animals.Add(new Dogs { id = TestData.id, Name = TextBoxAddName.Text, Age = int.Parse(TextBoxAddAge.Text), Description = TextBoxAddDescription.Text });
                        break;
                    case Hamster:
                        TestData.animals.Add(new Hamster { id = TestData.id, Name = TextBoxAddName.Text, Age = int.Parse(TextBoxAddAge.Text), Description = TextBoxAddDescription.Text });
                        break;
                }
                count++;
                TestData.id++;
                ItemPanelAnimalList itemPanelAnimalList = new ItemPanelAnimalList();
                itemPanelAnimalList.Count = count;

                Close();
            }
        }


    }
}