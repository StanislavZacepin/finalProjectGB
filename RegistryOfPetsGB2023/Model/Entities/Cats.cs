using RegistryOfPetsGB2023.Enum;
using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Entities.Base;
using System;
using System.Windows;

namespace RegistryOfPetsGB2023.Model.Entities
{
    internal class Cats : Entity, IAnimal
    {


        public void Voice()
        {
            MessageBox.Show("Мяу");
        }
    }
}
