using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using LastRace.Desktop.Models;
using Microsoft.EntityFrameworkCore;

namespace LastRace.Desktop.ViewModels;

public partial class UserPageViewModel : ViewModelBase
{
    [ObservableProperty] User user;

    public UserPageViewModel()
    {
        user = MainWindowViewModel.Instance.currentUser;
    }
}