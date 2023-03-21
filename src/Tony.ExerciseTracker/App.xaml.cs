namespace Tony.ExerciseTracker;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var navPage = new NavigationPage(new MainPage());

		navPage.BackgroundColor = Colors.Chocolate;
		navPage.BarTextColor = Colors.Red;

		MainPage = navPage;
	}
}
