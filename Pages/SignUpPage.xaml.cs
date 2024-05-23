namespace AutoSchoolApp.Pages;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    private void RegButton_Clicked(object sender, EventArgs e)
    {
      Navigation.PopToRootAsync();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}