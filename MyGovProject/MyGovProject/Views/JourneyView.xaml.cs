using MyGovProject.ViewModels;

namespace MyGovProject.Views;

public partial class JourneyView : ContentPage
{
	public JourneyView(JourneyViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}