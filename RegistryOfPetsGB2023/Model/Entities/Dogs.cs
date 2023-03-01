using RegistryOfPetsGB2023.Enum;
using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Entities.Base;
using System;
using System.Windows;

namespace RegistryOfPetsGB2023.Model.Entities
{
    internal class Dogs : Entity, IAnimal
    {
        public string Animal { get; } = "Собака";
        public TypeOfAnimal typeOfanimal { get; } = TypeOfAnimal.Домашние_животное;

        public void Voice()
        {
            MessageBox.Show("Гав");
        }

        public override string ToString()
        {
            return $"{Animal}, {typeOfanimal}";
        }
    }
}
