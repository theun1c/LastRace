using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace LastRace.Desktop.ViewModels;

public partial class LoginPageViewModel : ViewModelBase
{
    [ObservableProperty] string login;
    [ObservableProperty] string password;
    [ObservableProperty] string message;

    public void Enter()
    {
        MainWindowViewModel.Instance.currentUser = db.Users.FirstOrDefault(x => x.Email == login && x.PasswordHash == password);

        if (MainWindowViewModel.Instance.currentUser != null)
        {
            Message = "You logged in.";
            MainWindowViewModel.Instance.PageSwitcher = new UserPageViewModel();
        } 
        else
        {
            Message = "You entered incorrect password.";
        }
    }
}