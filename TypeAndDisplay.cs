using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_NavigationViewModelFirst
{
    public class TypeAndDisplay : ObservableObject
    {
        public string Name { get; set; }
        public Type VMType { get; set; }
    }
}
