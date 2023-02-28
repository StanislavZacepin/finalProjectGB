using RegistryOfPetsGB2023.Enum;
using RegistryOfPetsGB2023.Interfaces;
using RegistryOfPetsGB2023.Model.Entities;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace RegistryOfPetsGB2023.Model.Data
{
    public static class TestData
    {

    

        private static Dogs dogs = new Dogs { id=1, Age = 3, Name = "Reks", typeOfanimal = TypeOfAnimal.Pet, Description = "Blabla" };
        
        private static Cats cats = new Cats { id = 2, Age = 5, Name = "Man9", typeOfanimal = TypeOfAnimal.Pet, Description = "Blabla" };
        private static Hamster hamster = new Hamster { id = 3, Age = 1, Name = "Xomi", typeOfanimal = TypeOfAnimal.Pet, Description = "Blabla" };

        public static List<IAnimal> animals { get; } = new List<IAnimal>() { dogs, cats, hamster };

       


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

