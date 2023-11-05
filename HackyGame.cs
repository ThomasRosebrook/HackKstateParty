using Godot;
using System;

public partial class HackyGame : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		var player = GetNode<Area2D>("Player");
		player.Position = new Vector2(576, 300);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
