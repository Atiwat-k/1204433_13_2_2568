using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Model;
using Microsoft.Extensions.Options;

namespace MauiApp1.ViewModel;

public partial class ShowObjectsViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<User> users = new ObservableCollection<User>();

       [RelayCommand]
    void Click(long id){
        System.Diagnostics.Debug.WriteLine(id);
    }


    async Task<List<User>> ReadJsonAsync()
    {
        try
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("users.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            List<User> users = User.FromJson(contents);
            return users;
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message);
            return new List<User>();
        }
    }
    	// Constructor
    public ShowObjectsViewModel()
    {
        LoadDataAsync();
    }
    
	// LoadDataAsync
    async Task LoadDataAsync()
    {
        var jsonUsers = await ReadJsonAsync();
        // Convert to observable collection
        Users = new ObservableCollection<User>(jsonUsers);
    }
}