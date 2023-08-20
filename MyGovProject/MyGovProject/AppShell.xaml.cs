using MyGovProject.Views;

namespace MyGovProject;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(OnboardingView), typeof(OnboardingView));
		Routing.RegisterRoute(nameof(JourneyView), typeof(JourneyView));
	}
}
