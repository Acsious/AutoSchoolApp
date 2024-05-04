namespace AutoSchoolApp.Pages;

public partial class OnboardingPage : ContentPage
{
	public OnboardingPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignInPage());
        //await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SignUpPage());
    }
}