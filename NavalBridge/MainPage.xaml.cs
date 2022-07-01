using NavalBridge.Models;
using Logic;

namespace NavalBridge;

public partial class MainPage : ContentPage
{
	int count = 0;
    Logic.Logic _logic;
    BoardViewModel _model;

	public MainPage()
	{
		InitializeComponent();

        _logic = new Logic.Logic();
        _model = new BoardViewModel(_logic, 8);
    }

	private async void Navigate(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new Pages.HomePage());
    }
}

