using CommunityToolkit.Mvvm.ComponentModel;
using LastRace.Desktop.Models;

namespace LastRace.Desktop.ViewModels;

public abstract class ViewModelBase : ObservableObject
{
    public static PostgresContext db = new PostgresContext();
}