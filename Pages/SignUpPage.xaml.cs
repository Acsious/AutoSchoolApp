using AutoSchoolApp.ViewModels;

namespace AutoSchoolApp.Pages;

public partial class SignUpPage : ContentPage
{
    SignUpViewModel SignUpViewModel { get; set; }
    public SignUpPage()
    {
        InitializeComponent();
        this.BindingContext = SignUpViewModel = new SignUpViewModel();
    }

    private async void RegButton_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Ошибка", "Данный логин уже занят", "ОK");

        await DisplayAlert("Ошибка", "Недопустимый логин или пароль. Логин может включать только латинские буквы," +
            "цифры и знак _, длина - от 3 до 20 символов. Пароль должен включать в себя цифры и буквы, длина - от 8 до 20 символов.", "ОK");

        //Navigation.PopToRootAsync();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}