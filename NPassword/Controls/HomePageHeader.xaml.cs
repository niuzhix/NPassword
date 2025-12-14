using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace NPassword.Controls;

public sealed partial class HomePageHeader : UserControl
{
    public List<string> CarouselImages { get; set; }
    private DispatcherTimer _timer;

    public HomePageHeader()
    {
        InitializeComponent();
    }
}