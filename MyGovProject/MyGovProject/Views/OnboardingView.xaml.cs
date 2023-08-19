using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyGovProject.ViewModels;

namespace MyGovProject.Views;

public partial class OnboardingView : ContentPage
{
	public OnboardingView(OnboardingViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
	}
}