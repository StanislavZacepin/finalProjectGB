using RegistryOfPetsGB2023.Enum;
using RegistryOfPetsGB2023.Interfaces;
using System.Windows.Controls;
using System;
using System.Collections.Generic;

namespace RegistryOfPetsGB2023.Model.Entities.Base
{
    public abstract class Entity 
    {
        

        public int id { get; set; }
        public string Name { get; set; }

        public List<string> ListComand { get; set; }

        public int Age { get; set; }
       
        public string Description { get; set; }       

        public override string ToString() => $"{id} {Name} {Age} {Description} ";
        


    }
}

