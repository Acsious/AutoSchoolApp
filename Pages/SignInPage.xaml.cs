namespace AutoSchoolApp.Pages;

public partial class SignInPage : ContentPage
{
	public SignInPage()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new ForgotPasswordPage());
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new SignUpPage());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HomePage());
    }
}