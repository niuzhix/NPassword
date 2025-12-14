using Microsoft.UI.Xaml.Controls;

using NPassword.ViewModels;

namespace NPassword.Views;

public sealed partial class InfoPage : Page
{
    public InfoViewModel ViewModel
    {
        get;
    }

    public InfoPage()
    {
        ViewModel = App.GetService<InfoViewModel>();
        InitializeComponent();
    }
}
