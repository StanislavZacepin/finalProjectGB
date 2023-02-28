using RegistryOfPetsGB2023.Enum;
using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Entities;
using RegistryOfPetsGB2023.Model.Entities.Base;
using System.Collections.ObjectModel;

namespace RegistryOfPetsGB2023.Model.Data
{
    public static class TestData
    {

    

        private static Dogs dogs = new Dogs { id=1, Age = 3, Name = "Рекс", typeOfanimal = TypeOfAnimal.Pet, Description = "Чтото там" };
        
        private static Cats cats = new Cats { id = 2, Age = 5, Name = "Маня", typeOfanimal = TypeOfAnimal.Pet, Description = "Где то там" };
        private static Hamster hamster = new Hamster { id = 3, Age = 1, Name = "Хоми", typeOfanimal = TypeOfAnimal.Pet, Description = "Както там" };

        public  static ObservableCollection<IAnimal> animals { get; } = new ObservableCollection<IAnimal>() { dogs, cats, hamster };

       
        public static void AnimDelite(IAnimal animal)
        {
            animals.Remove(animal);
        }

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

