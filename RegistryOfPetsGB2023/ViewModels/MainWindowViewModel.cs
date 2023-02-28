using RegistryOfPetsGB2023.Model.Data;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace RegistryOfPetsGB2023.ViewModels
{
    class MainWindowViewModel
    {



        private string _Title = "Список Заповедника GB";

        public string Title { get => _Title; }

        private string _Status = "Готов!";

        public string Status { get => _Status; }

        



    }
}
