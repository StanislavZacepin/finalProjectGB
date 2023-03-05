using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Data;
using RegistryOfPetsGB2023.Model.Entities;
using RegistryOfPetsGB2023.Model.Entities.Base;
using RegistryOfPetsGB2023.View.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace RegistryOfPetsGB2023.ViewModels
{
    public class MainWindowViewModel
    {



        private static string _Title = "Реестр Заповедника GB";

        public static string Title { get => _Title; }

        private static string _Status = "Готов!";
        public static string Status { get => _Status; }

        public static bool Flag { get; set; } = false;


        /// <summary>
        /// Запустить окно для добавления животного
        /// </summary>
        public void StartWindowAdd()
        {

            WindowAddAnimals windowAddAnimals = new WindowAddAnimals();
            if (Flag == false)
            {
                Flag = true;
                windowAddAnimals.Show();
            }
                
        }


        /// <summary>
        /// Метод Удаления жипостного
        /// </summary>
        /// <param name="entity"></param>
        public void DeliteAnimals(IAnimal entity)
        {

            if (entity != null && TestData.animals != null)
            {
                TestData.AnimDelite(entity);
            }
        }


        /// <summary>
        /// Метод Добавления Животного
        /// </summary>
        /// <param name="TextBoxAddName"></param>
        /// <param name="ComboBoxAddAnimals"></param>
        /// <param name="TextBoxAddAge"></param>
        /// <param name="TextBoxAddDescription"></param>
        public void Addanim(TextBox TextBoxAddName, ComboBox ComboBoxAddAnimals, TextBox TextBoxAddAge, TextBox TextBoxAddDescription)
        {
            int n;
            bool isNumeric = int.TryParse(TextBoxAddAge.Text, out n);
            if (!isNumeric || int.Parse(TextBoxAddAge.Text) < 0 || int.Parse(TextBoxAddAge.Text) > 25)
            {
                MessageBox.Show("В столбце Сколко лет. Можно водить только цыфры от 0 25");
            }
            else if (string.IsNullOrEmpty(TextBoxAddName.Text) || string.IsNullOrEmpty(ComboBoxAddAnimals.Text) || string.IsNullOrEmpty(TextBoxAddAge.Text) || string.IsNullOrEmpty(TextBoxAddDescription.Text))
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
                    case Camel:
                        TestData.animals.Add(new Camel { id = TestData.id, Name = TextBoxAddName.Text, Age = int.Parse(TextBoxAddAge.Text), Description = TextBoxAddDescription.Text });
                        break;
                    case Donkey:
                        TestData.animals.Add(new Donkey { id = TestData.id, Name = TextBoxAddName.Text, Age = int.Parse(TextBoxAddAge.Text), Description = TextBoxAddDescription.Text });
                        break;
                    case Horse:
                        TestData.animals.Add(new Horse { id = TestData.id, Name = TextBoxAddName.Text, Age = int.Parse(TextBoxAddAge.Text), Description = TextBoxAddDescription.Text });
                        break;
                }
                TestData.id++;
            }
        }

    }
}
