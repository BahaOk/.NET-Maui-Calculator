namespace MauiApp1;

public partial class RegisterScreen : ContentPage
{
	public RegisterScreen()
	{
		InitializeComponent();
	}

	private void Kayit_Olundu(object sender, EventArgs e){
		Navigation.PushAsync(new LoginScreen());
	}
}