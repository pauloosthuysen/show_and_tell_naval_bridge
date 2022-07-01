using Logic;
using Microsoft.Maui.Controls;
using NavalBridge.Models;

namespace NavalBridge.Pages;

public partial class HomePage : ContentPage
{
    Logic.Logic _logic;
    BoardViewModel _model;

    public HomePage()
    {
        InitializeComponent();

        _logic = new Logic.Logic();
        _model = new BoardViewModel(_logic, 5);
    }

    private void DropGestureRecognizer_Drop1(object sender, DropEventArgs e)
    {

    }

    private void DragGestureRecognizer_DragStarting_Chair(object sender, DragStartingEventArgs e)
    {

    }

    private void DragGestureRecognizer_DragStarting_Desk(object sender, DragStartingEventArgs e)
    {

    }

    private void Button_Clicked(object sender, EventArgs e)
    {

        Button clickedButton = sender as Button;
        var name = clickedButton.Id;

        //clickedButton.BackgroundColor = Colors.White;
        Grid parentObject = clickedButton.Parent as Grid;

        int rowIndex = parentObject.GetRow(clickedButton);
        int columnIndex = parentObject.GetColumn(clickedButton);

        var chars = new char[] { 'A', 'B', 'C', 'D', 'E' };
        var selectedRow = chars[rowIndex - 1];
        var isChair = _model.SetHit(selectedRow, columnIndex);
        var isHit = _model.IsHit(selectedRow, columnIndex);

        if (isHit)
        {
            clickedButton.Background = Colors.Blue;
        }
        else 
        {
            clickedButton.Background = Colors.Red;
        }
        //Border border = parentObject as Border;
        //if (border != null)
        //{
        //    int rowIndex = Grid.GetRow(border);
        //    grdVictims.Children.Remove(border); //remove the entire Border element
        //    grdVictims.RowDefinitions.RemoveAt(rowIndex); //remove the row
        //}
    }
}