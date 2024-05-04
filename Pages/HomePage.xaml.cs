namespace AutoSchoolApp.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    //private void OnAvatarTapped(object sender, EventArgs e)
    //{
    //    // Handle avatar tapped event, navigate to personal account page
    //}

    private void OnPracticalTrainingClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new DrivingSignPage());
    }

    private void OnAnswerQuestionsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ChooseQuestionPage());
    }

    private void OnSolveTicketsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ChooseTicketPage());
    }
}