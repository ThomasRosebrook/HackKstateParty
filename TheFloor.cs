using Godot;
using System;

public partial class TheFloor : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Position = new Vector2(576, 950);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GD.Print();
		Position = new Vector2(Position.X, Position.Y - (float)0.1);
	}
}
