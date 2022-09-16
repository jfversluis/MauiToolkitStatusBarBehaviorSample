namespace MauiToolkitStatusBarBehaviorSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		statusBar.StatusBarColor = Colors.Pink;
        statusBar.StatusBarStyle = CommunityToolkit.Maui.Core.StatusBarStyle.DarkContent;

    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
        //statusBar.StatusBarColor = Colors.Red;
        //statusBar.StatusBarStyle = CommunityToolkit.Maui.Core.StatusBarStyle.LightContent;

		Navigation.PushAsync(new ContentPage());

        count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

