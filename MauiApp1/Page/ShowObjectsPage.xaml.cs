using MauiApp1.ViewModel;

namespace MauiApp1.Page;

public partial class ShowObjectsPage : ContentPage
{
	public ShowObjectsPage()
	{
		InitializeComponent();
		BindingContext = new ShowObjectsViewModel();
	}
}