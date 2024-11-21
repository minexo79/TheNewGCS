using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TheNewGCS.ViewModels
{
    public partial class CameraViewModel : ObservableObject
    {
        [ObservableProperty]
        public Visibility isMaximize = Visibility.Hidden;
    }
}
