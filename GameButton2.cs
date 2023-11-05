using Godot;
using System;

public partial class GameButton2 : Button
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
		//Funny
        GD.Print("Game is starting!!!!!!!!!!!!!!!!!!!!!!!");
		GetTree().ChangeSceneToFile("res://HackyGame2/game_1.tscn");
	}
}
