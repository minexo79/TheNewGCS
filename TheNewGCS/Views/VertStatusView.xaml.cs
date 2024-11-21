﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using TheNewGCS.ViewModels;

namespace TheNewGCS.Views;

public partial class VertStatusView : UserControl
{
    StatusViewModel statusViewModel = new StatusViewModel();

    public string StatusType
    {
        get => statusViewModel.StatusType;
        set
        {
            statusViewModel.StatusType = value;
        }
    }

    public string StatusValue
    {
        get => statusViewModel.StatusValue;
        set
        {
            statusViewModel.StatusValue = value;
        }
    }


    public VertStatusView()
    {
        InitializeComponent();

        StatusGrid.DataContext = statusViewModel;
    }

}