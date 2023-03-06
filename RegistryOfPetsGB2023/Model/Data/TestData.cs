﻿using RegistryOfPetsGB2023.Enum;
using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Entities;
using RegistryOfPetsGB2023.Model.Entities.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RegistryOfPetsGB2023.Model.Data
{
    public static class TestData
    {

        public static int id { get; set; } = 7;


        #region Создание обьектов для Test Даты
        private static Dogs dogs = new Dogs { id = 1, Age = 3, Name = "Рекс", Description = "Что-то там" };
        private static Cats cats = new Cats { id = 2, Age = 5, Name = "Маня", Description = "Где то там" };
        private static Hamster hamster = new Hamster { id = 3, Age = 1, Name = "Хоми", Description = "парам пам пам" };
        private static Donkey donkey = new Donkey { id = 4, Age = 13, Name = "Лала", Description = "парам пам пам" };
        private static Horse horse = new Horse { id = 5, Age = 10, Name = "Пегас", Description = "парам пам пам" };
        private static Camel camel = new Camel { id = 6, Age = 8, Name = "Джо", Description = "парам пам пам" };
        #endregion
       

        
        public static string GlavText { get; set; } = "13. Создать класс с Инкапсуляцией методов и наследованием по диаграмме.\r\n14. Написать программу, имитирующую работу реестра домашних животных.\r\nВ программе должен быть реализован следующий функционал:\r\n14.1 Завести новое животное\r\n14.2 определять животное в правильный класс\r\n14.3 увидеть список команд, которое выполняет животное\r\n14.4 обучить животное новым командам\r\n14.5 Реализовать навигацию по меню\r\n15. Создайте класс Счетчик, у которого есть метод add(), увеличивающий̆\r\nзначение внутренней̆ int переменной̆ на 1 при нажатии “Завести новое\r\nживотное” Сделайте так, чтобы с объектом такого типа можно было работать в\r\nблоке try-with-resources. Нужно бросить исключение, если работа с объектом\r\nтипа счетчик была не в ресурсном try и/или ресурс остался открыт. Значение\r\nсчитать в ресурсе try, если при заведении животного заполнены все поля.";

        public static ObservableCollection<Entity> animals { get; set; } = new ObservableCollection<Entity>() { dogs, cats, hamster, donkey, horse, camel };

      
       

      
        /* public static List<Dogs> dogs { get; set; } = Enumerable.Range(1, 3)
.Select(i => new Dogs
{
    id = i,
    Name = $"Dogs-{i}",
    Age = i,
    typeOfanimal = TypeOfAnimal.Pet,
    Description = $"Описанние-{i}",
}).ToList();*/

        /* public static List<Cats> cats { get; set; } = Enumerable.Range(1, 3)
        .Select(i => new Cats
        {
            id = i,
            Name = $"Cats-{i}",
            Age = i,
            typeOfanimal = TypeOfAnimal.Pet,
            Description = $"Описанние-{i}",
        }).ToList();*/

        /*  public static List<Hamster> hamsters { get; set; } = Enumerable.Range(1, 3)
        .Select(i => new Hamster
        {
            id = i,
            Name = $"Hamster-{i}",
            Age = i,
            typeOfanimal = TypeOfAnimal.Pet,
            Description = $"Описанние-{i}",
        }).ToList();
  */

    }
}

