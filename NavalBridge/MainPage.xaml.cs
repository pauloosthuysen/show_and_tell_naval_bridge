﻿using NavalBridge.Models;

namespace NavalBridge;

public partial class MainPage : ContentPage
{
	int count = 0;
    BoardViewModel model = new BoardViewModel(8);

	public MainPage()
	{
		InitializeComponent();
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
		model.SetHit('A', 5);
	}
}

