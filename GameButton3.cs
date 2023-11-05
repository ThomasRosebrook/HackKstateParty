using Godot;
using System;

public partial class GameButton3 : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

    public void button_press3()
    {
    GetTree().ChangeSceneToFile("res://GameShow.tscn");
	// Replace with function body.
}
}
