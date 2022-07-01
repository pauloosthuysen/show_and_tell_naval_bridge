using Logic;
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
}