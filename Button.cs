using Godot;
using System;

public partial class Button : Godot.Button
{
	// Called when the node enters the scene tree for the first time.

	//Button button = new Button();
	
	public override void _Ready()
	{
		this.
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void button_press()
	{
		Text = "YOu pressed it";
		GD.Print("Game is starting!!!!!!!!!!!!!!!!!!!!!!!");
		GetTree().ChangeSceneToFile("Lukes Stuff (STAY OUT MAN ITS JUST MY HOMEWORK FOLDER CHILL)\\player.tscn");
	}
}
