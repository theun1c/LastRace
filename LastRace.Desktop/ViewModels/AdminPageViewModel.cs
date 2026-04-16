using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using LastRace.Desktop.Models;
using Microsoft.EntityFrameworkCore;

namespace LastRace.Desktop.ViewModels;

public partial class AdminPageViewModel : ViewModelBase
{
    [ObservableProperty] List<User> users = db.Users.Include(x => x.Role).ToList();
}