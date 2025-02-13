using MauiApp1.Page;

namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("forgetpassword", typeof(ForgetPasswordPage));
		Routing.RegisterRoute("register", typeof(RegisterPage));
	}
}
