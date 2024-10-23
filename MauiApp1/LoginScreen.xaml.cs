namespace MauiApp1;

public partial class LoginScreen : ContentPage
{
	public LoginScreen()
	{
		InitializeComponent();
	
	}

	private void Giris_Butonu(object sender, EventArgs e){
		App.Current.MainPage = new AppShell();	
	}
	private void Kayit_Butonu(object sender, EventArgs e){
		Navigation.PushAsync(new RegisterScreen());
	}
}