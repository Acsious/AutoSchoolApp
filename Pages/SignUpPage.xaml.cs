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
        await DisplayAlert("������", "������ ����� ��� �����", "�K");

        await DisplayAlert("������", "������������ ����� ��� ������. ����� ����� �������� ������ ��������� �����," +
            "����� � ���� _, ����� - �� 3 �� 20 ��������. ������ ������ �������� � ���� ����� � �����, ����� - �� 8 �� 20 ��������.", "�K");

        //Navigation.PopToRootAsync();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}