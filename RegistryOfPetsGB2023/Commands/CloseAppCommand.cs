using System.Windows;
using RegistryOfPetsGB2023.Commands.Base;

namespace RegistryOfPetsGB2023.Commands
{
    public class CloseAppCommand : Command
    {
        public override void Execute(object parameter) => Application.Current.Shutdown();

    }
}
