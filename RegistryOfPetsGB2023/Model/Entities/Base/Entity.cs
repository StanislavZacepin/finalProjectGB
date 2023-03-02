using RegistryOfPetsGB2023.Enum;
using RegistryOfPetsGB2023.Interfaces;
using System.Windows.Controls;
using System;

namespace RegistryOfPetsGB2023.Model.Entities.Base
{
    public abstract class Entity
    {
        

        public int id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
       
        public string Description { get; set; }       

        public override string ToString() => $"{id} {Name} {Age} {Description} ";
        


    }
}

