using System.Drawing;

namespace NavalBridge;

public partial class MainPage : ContentPage
{
	int columnCount = 5;
	int rowCount = 5;
    int[,] grid;

	public MainPage()
	{
		InitializeComponent();
		InitialiseGrid();
	}

	private void InitialiseGrid()
	{
		grid = new int[5,5];

		for(int i = 0; i < rowCount; i++)
		{
            for (int k = 0; k < columnCount; k++)
            {
				grid[i,k] = i;
            }
        }
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
       
    }
}

