using Godot;
using System;

public partial class TheFloor : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        Position = new Vector2(0, 0);
        //Position = new Vector2(576, 950);
        //Position = new Vector2(576, 50);
        //Show();
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Position.Y > -600) Position = new Vector2(Position.X, Position.Y - (float)2);
	}
	
}
