using RegistryOfPetsGB2023.Enum;
using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Entities.Base;
using System;
using System.Windows;

namespace RegistryOfPetsGB2023.Model.Entities
{
    internal class Donkey : Entity, IAnimal
    {
        public string Animal { get; } = "Осёл";

        public TypeOfAnimal typeOfanimal { get; } = TypeOfAnimal.Вьючное_животное;

        public void Voice()
        {
            MessageBox.Show("qwertyu");
        }

        public override string ToString()
        {
            return $"{Animal}, {typeOfanimal}";
        }
    }
}
