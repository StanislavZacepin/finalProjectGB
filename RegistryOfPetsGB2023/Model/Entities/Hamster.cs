﻿using RegistryOfPetsGB2023.Enum;
using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Entities.Base;
using System;
using System.Windows;

namespace RegistryOfPetsGB2023.Model.Entities
{
    internal class Hamster : Entity, IAnimal
    {
      

        public void Voice()
        {
            MessageBox.Show("Шурм шурум");
        }
    }
}
