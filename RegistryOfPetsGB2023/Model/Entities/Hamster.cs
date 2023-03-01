using RegistryOfPetsGB2023.Enum;
using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Entities.Base;
using System;
using System.Windows;

namespace RegistryOfPetsGB2023.Model.Entities
{
    internal class Hamster : Entity, IAnimal
    {

        public string Animal { get; } = "Хомяк";
        public TypeOfAnimal typeOfanimal { get; } = TypeOfAnimal.Домашние_животное;

        public void Voice()
        {
            MessageBox.Show("Шурм шурум");
        }
        public override string ToString()
        {
            return $"{Animal}, {typeOfanimal}";
        }
    }
}
