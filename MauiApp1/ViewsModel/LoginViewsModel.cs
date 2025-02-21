using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Page;

namespace MauiApp1.ViewsModel;

public partial class LoginViewsModel : ObservableObject
{

    [ObservableProperty]
    string username="";
    [ObservableProperty]
    string password="";
    
   [RelayCommand]
   async Task Login()
   {
      System.Diagnostics.Debug.Print("Username: " + Username);
      System.Diagnostics.Debug.Print("Password: " + Password);
      await GotoPage(nameof(ShowObjectsPage));
   }

    [RelayCommand]
    async Task GotoPage(string page)
    {
        await Shell.Current.GoToAsync(page);
    }
}
