using CommunityToolkit.Mvvm.ComponentModel;

namespace LastRace.Desktop.ViewModels;

public partial class LoginPageViewModel : ViewModelBase
{
    [ObservableProperty] string login;
    [ObservableProperty] string password;
    [ObservableProperty] string message;

    public void Enter()
    {
        if (Login != "admin")
        {
            Message = "You entered incorrect login.";
        } 
        else if (Password != "admin")
        {
            Message = "You entered incorrect password.";
        }
        else
        {
            // else role == какая-то роль то в свиче выводить разные страницы
            
            Message = "You logged in.";
            
            MainWindowViewModel.Instance.PageSwitcher = new AdminPageViewModel();
        }
        
    }
}