using CommunityToolkit.Mvvm.ComponentModel;

namespace LastRace.Desktop.ViewModels;

public partial class LoginPageViewModel : ViewModelBase
{
    [ObservableProperty] string login;
    [ObservableProperty] string password;
    
    
}