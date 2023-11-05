using Godot;
using System;

public partial class HUD : CanvasLayer
{
	[Signal]
	public delegate void StartGameEventHandler();
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public void ShowMessage(string text)
    {
        var message = GetNode<Godot.Label>("Message");
        message.Text = text;
        message.Show();
    }

    public void ShowGameOver()
    {
        ShowMessage("Game Over");

        GetNode<Button>("Start").Show();
        GetNode<Button>("MenuButton").Show();
    }

    public void UpdateScore(int score)
    {
        GetNode<Godot.Label>("ScoreLabel").Text = score.ToString();
    }

    private void OnStartButtonPressed()
    {
        GetNode<Button>("Start").Hide();
        GetNode<Button>("MenuButton").Hide();
        GetNode<Godot.Label>("Message").Hide();
        EmitSignal(SignalName.StartGame);
    }
}
