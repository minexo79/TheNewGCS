using System.ComponentModel;
using System.Windows.Controls;

namespace TheNewGCS.Controls;

public partial class IconButton : Button, INotifyPropertyChanged
{
    private string _icon = "N/A";
    public string Icon
    {
        get => _icon;
        set { _icon = value; OnPropertyChanged(nameof(Icon)); }
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged(string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    public IconButton()
    {
        InitializeComponent();

        this.DataContext = this;
    }
}