using CommunityToolkit.Mvvm.ComponentModel;
using AutoSchoolApp.Models;

namespace AutoSchoolApp.ViewModels
{
    public partial class SignUpViewModel : ObservableObject
    {
        [ObservableProperty]
        private Schedule _schedule;
    }
}
