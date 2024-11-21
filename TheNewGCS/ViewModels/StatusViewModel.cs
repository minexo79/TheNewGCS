using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace TheNewGCS.ViewModels
{
    public partial class StatusViewModel : ObservableObject
    {
        [ObservableProperty]
        private string statusValue = "N/A";

        [ObservableProperty]
        private string statusType = "N/A";
    }
}
