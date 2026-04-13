using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using LastRace.Desktop.Models;
using Microsoft.EntityFrameworkCore;

namespace LastRace.Desktop.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
   
    
    [ObservableProperty] private ViewModelBase pageSwitcher = new LoginPageViewModel();
    public User? currentUser = db.Users.Include(x => x.Role).FirstOrDefault();
    
    public static MainWindowViewModel Instance { get; set; }

    public MainWindowViewModel()
    {
        Instance = this;
    }
}