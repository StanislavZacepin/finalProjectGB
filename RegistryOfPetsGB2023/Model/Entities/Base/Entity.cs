using RegistryOfPetsGB2023.Enum;
using RegistryOfPetsGB2023.Interfaces;
using System.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RegistryOfPetsGB2023.Model.Entities.Base
{
    public abstract class Entity
    {
        

        public int id { get; set; }
        public string Name { get; set; }

        public ObservableCollection<ComandAnim> ComandAnims { get; set; } = new ObservableCollection<ComandAnim>() 
        {
            new ComandAnim { NameComand = "Сидеть", ComandAnimDescription = "мне надо сесть" },
            new ComandAnim { NameComand = "Можно", ComandAnimDescription =  "мне мне можно приступить к трапизе" },
            new ComandAnim { NameComand = "Фу", ComandAnimDescription =  "Прикратить действия" },
        };

        public int Age { get; set; }
       
        public string Description { get; set; }       

        public override string ToString() => $"{id} {Name} {Age} {Description} ";
        


    }
}

