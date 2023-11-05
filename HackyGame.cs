using Godot;
using System;

public partial class HackyGame : Node2D
{
	private int _score;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		NewGame();
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionPressed("Escape"))
		{

			GetTree().ChangeSceneToFile("res://Menu.tscn");
		}
		
	}

	public void GameOver()
	{

	}

	public void NewGame()
	{
		_score = 0;
		var player = GetNode<Player>("Player");
		player.Start(new Vector2(576, 300));
		AudioStreamPlayer bgMusic = GetNode<AudioStreamPlayer>("BGMusic");
		bgMusic.Play();
	}
}
