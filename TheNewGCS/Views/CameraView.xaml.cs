using System.Windows.Controls;
using TheNewGCS.ViewModels;

namespace TheNewGCS.Views;

public partial class CameraView : UserControl
{
    CameraViewModel cameraViewModel = new CameraViewModel();

    public CameraView()
    {
        InitializeComponent();

        this.DataContext = cameraViewModel;
    }
}