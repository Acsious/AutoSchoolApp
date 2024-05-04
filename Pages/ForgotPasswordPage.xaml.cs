namespace AutoSchoolApp.Pages;

public partial class ForgotPasswordPage : ContentPage
{
    //public ForgotPasswordPage(ForgotPasswordModel vm)
    //{
    //    InitializeComponent();
    //    BindingContext = vm;
    //}

    public ForgotPasswordPage()
    {
        InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PopToRootAsync();
    }

    private void ResetButton_Clicked(object sender, EventArgs e)
    {
        //Navigation.PushAsync(new ResetPage());
    }
}