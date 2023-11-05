using Godot;
using System;
public partial class GameButton1 : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	

	public void button_press()
	{
		Text = "You pressed it";
		GD.Print("Game is starting!!!!!!!!!!!!!!!!!!!!!!!");
		GD.Print("this is cool");
		GetTree().ChangeSceneToFile("res://HackyGame.tscn");
	}
}
