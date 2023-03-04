using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_NavigationViewModelFirst
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string mainWinVMString = "Hello from MainWindoViewModel";

        [ObservableProperty]
        private object currentViewModel = null;

        [ObservableProperty]
        List<TypeAndDisplay> navigationViewModelTypes = new List<TypeAndDisplay>
            {
               new TypeAndDisplay{ Name="Yellow", VMType= typeof(YellowViewModel) },
               new TypeAndDisplay{ Name="Blue", VMType= typeof(BlueViewModel) }
            };

        [RelayCommand]
        private void Navigate(Type vmType)
        {
            CurrentViewModel = null;
            if (viewModels.ContainsKey(vmType))
            {
                CurrentViewModel = viewModels[vmType];
                return;
            }
            CurrentViewModel = Activator.CreateInstance(vmType);
            viewModels.Add(vmType, CurrentViewModel);
        }

        private Dictionary<Type, Object> viewModels = new Dictionary<Type, Object>();
    }
}
