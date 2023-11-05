using Godot;
using System;

public partial class Menu : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("TEST");
		Start();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void Start()
	{
		AudioStreamPlayer menuMusic = GetNode<AudioStreamPlayer>("MenuMusic");
		menuMusic.Play();
	}
}

