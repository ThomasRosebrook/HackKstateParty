using Godot;
using System;

public partial class Button : Godot.Button
{
	// Called when the node enters the scene tree for the first time.

	//Button button = new Button();
	
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame. 
	public override void _Process(double delta)
	{
	}

	public void button_press2()
	{
		//Text = "YOu pressed it";
        GD.Print("Game is starting!!!!!!!!!!!!!!!!!!!!!!!");
		//GD.Print("Why it not work");
		GetTree().ChangeSceneToFile("res://HackyGame2/game_1.tscn");
	}
}
