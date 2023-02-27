using RegistryOfPetsGB.Enum;
using RegistryOfPetsGB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistryOfPetsGB.Model.Entity
{
    internal class Dogs : IAnimal
    {
        public string? Name { get; set; }

        public int Age { get; set; }

        public TypeOfAnimal typeOfanimal { get; set; }
        public string? Description { get; set; }

        public void Voice()
        {
            Console.WriteLine("Гав");
        }
    }
}
