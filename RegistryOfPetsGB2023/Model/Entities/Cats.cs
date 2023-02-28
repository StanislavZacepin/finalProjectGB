using RegistryOfPetsGB2023.Enum;
using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Entities.Base;
using System;

namespace RegistryOfPetsGB2023.Model.Entities
{
    internal class Cats : Entity, IAnimal
    {


        public void Voice()
        {
            Console.WriteLine("Мяу");
        }
    }
}
