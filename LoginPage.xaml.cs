namespace TicketCenter;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void IniciarSesion_Clicked(object sender, EventArgs e)
    {
		if (ValidarEmail.IsNotValid)
		{
			DisplayAlert("Error", "Correo inválido", "OK");
			return;
		}
    }
}