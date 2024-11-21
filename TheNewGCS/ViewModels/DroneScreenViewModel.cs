using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNewGCS.Views;

namespace TheNewGCS.ViewModels
{
    public partial class DroneScreenViewModel : ObservableObject
    {
        static MapView mapView = new MapView();
        static CameraView cameraView = new CameraView();

        [ObservableProperty]
        private object frameBigScreenContent = mapView;

        [ObservableProperty]
        private object frameTinyScreenContent = cameraView;

        enum Screen
        {
            Map,
            Camera
        } 

        Screen currentScreen = Screen.Map;

        [RelayCommand]
        private void ChangeScreen()
        {
            if (currentScreen == Screen.Map)
            {
                currentScreen = Screen.Camera;

                FrameBigScreenContent = cameraView;
                FrameTinyScreenContent = mapView;
            }
            else
            {
                currentScreen = Screen.Map;

                FrameBigScreenContent = mapView;
                FrameTinyScreenContent = cameraView;
            }
        }
    }
}
