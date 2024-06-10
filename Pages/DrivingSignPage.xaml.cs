//using Google.Android.Material.DatePicker;

namespace AutoSchoolApp.Pages;

public partial class DrivingSignPage : ContentPage
{
    DateTime selectedDate = new();

	public DrivingSignPage()
	{
        InitializeComponent();
        datePicker.MinimumDate = DateTime.Now;
        datePicker.MaximumDate = DateTime.Now.AddDays(7);
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
       await Navigation.PopToRootAsync();
    }

    private async void RegButton_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Ошибка", "Данное время уже занято", "ОK");

        await DisplayAlert("Запись создана", "Ваше занятие будет 06.06.2024 17:00", "ОK");
        await Navigation.PopAsync();
    }

    private void timePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {

    }

    private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        selectedDate = e.NewDate.Date;
    }
}