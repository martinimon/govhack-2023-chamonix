using CommunityToolkit.Mvvm.Input;
using MyGovProject.Views;

namespace MyGovProject.ViewModels;

public partial class OnboardingViewModel
{
    [RelayCommand]
    public async Task NavigateToPage()
    {
        await Shell.Current.GoToAsync(nameof(JourneyView));

    }
}


