using NavalBridge.Models;

namespace NavalBridge;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private async void Navigate(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new Pages.HomePage());
    }
}

