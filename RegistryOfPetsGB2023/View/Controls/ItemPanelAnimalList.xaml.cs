﻿using RegistryOfPetsGB2023.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RegistryOfPetsGB2023.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ItemPanelAnimalList.xaml
    /// </summary>
    public partial class ItemPanelAnimalList : UserControl
    {
        public ItemPanelAnimalList()
        {
            InitializeComponent();
        }
        
        public void LoadedTestData()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TestData.AnimDelite(1);
        }
    }
}
