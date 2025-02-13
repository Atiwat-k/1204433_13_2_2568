using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiApp1.ViewsModel;

public partial class LoginViewsModel : ObservableObject
{

    [ObservableProperty]
    string username="";
    [ObservableProperty]
    string password="";
    
    [RelayCommand]
    void Login()
    {
        System.Diagnostics.Debug.Print("Username: " + Username);
        System.Diagnostics.Debug.Print("Password: " + Password);
    }
    [RelayCommand]
    async Task GotoPage(string page)
    {
        await Shell.Current.GoToAsync(page);
    }
}
