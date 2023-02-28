using RegistryOfPetsGB2023.Enum;

namespace RegistryOfPetsGB2023.Interfaces
{
    public partial interface IAnimal
    {
        int id { get; set; }

        string Name { get; set; }
        int Age { get; set; }
        string Description { get; set; }
        TypeOfAnimal typeOfanimal { get; set; }

        public void Voice();



    }
}
