using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace TheNewGCS.Views;

public partial class HoriStatusView : UserControl, INotifyPropertyChanged
{
    private string _statusValue = "N/A";
    public string StatusValue
    {
        get => _statusValue;
        set { _statusValue = value; OnPropertyChanged(nameof(StatusValue)); }
    }
    
    private string _statusType = "N/A";
    public string StatusType
    {
        get => _statusType;
        set { _statusType = value; OnPropertyChanged(nameof(StatusType)); }
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    public HoriStatusView()
    {
        InitializeComponent();

        StatusGrid.DataContext = this;
    }

}