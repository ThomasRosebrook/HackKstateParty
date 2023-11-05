using Godot;
using System;

public partial class example_grovving_dood : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        AnimatedSprite2D h1 = GetNode<AnimatedSprite2D>("Happy");
        AnimatedSprite2D h2 = GetNode<AnimatedSprite2D>("Happy2");
        AnimatedSprite2D h3 = GetNode<AnimatedSprite2D>("Happy3");
		h1.Play();
        h2.Play();
        h3.Play();
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
