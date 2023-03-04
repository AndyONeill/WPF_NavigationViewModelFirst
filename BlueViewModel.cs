using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_NavigationViewModelFirst
{
    public partial class BlueViewModel : ObservableObject
    {
        [ObservableProperty]
        string vmName = "Blue";
    }
}
