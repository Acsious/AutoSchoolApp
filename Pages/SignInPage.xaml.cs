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

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Ошибка", "Неверный логин или пароль", "ОK");

        await DisplayAlert("Ошибка", "К сожалению, ваш аккаунт заблокирован", "ОK");

        await Navigation.PushAsync(new HomePage());
    }
}