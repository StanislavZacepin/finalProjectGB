using RegistryOfPetsGB.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistryOfPetsGB.Interfaces
{
    public partial interface IAnimal
    {

        string Name { get; set; }
        int Age { get; set; }
        string Description { get; set; }
        TypeOfAnimal typeOfanimal { get; set; }

        public void Voice();



    }
}
