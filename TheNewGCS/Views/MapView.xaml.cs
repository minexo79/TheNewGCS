using System.Windows.Controls;
using TheNewGCS.ViewModels;

namespace TheNewGCS.Views;

public partial class MapView : UserControl
{
    public MapView()
    {
        InitializeComponent();

        droneMap.Map?.Layers.Add(Mapsui.Tiling.OpenStreetMap.CreateTileLayer());
    }
}