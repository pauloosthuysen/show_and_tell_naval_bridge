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

	private void OnCounterClicked(object sender, EventArgs e)
	{
        /*count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}*/

        // Test hit functionality
        _model.SetHit('A', 5);
	}
}

