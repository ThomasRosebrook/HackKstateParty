using Godot;
using System;

public partial class GameShowButton2 : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void button_joe()
	{
        GetTree().ChangeSceneToFile("res://gameshowwaddledoo/CorrectAnswer.tscn");
    }
}
