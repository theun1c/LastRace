using CommunityToolkit.Mvvm.ComponentModel;

namespace LastRace.Desktop.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty] private ViewModelBase pageSwitcher = new LoginPageViewModel();
    public static MainWindowViewModel Instance { get; set; }

    public MainWindowViewModel()
    {
        Instance = this;
    }
}