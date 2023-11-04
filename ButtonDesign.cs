using Godot;
using System;

public partial class ButtonDesign : TextureButton
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		DrawRectangle();
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void DrawRectangle()
	{
		DrawRect(new Rect2(1.0f, 1.0f, 3.0f, 3.0f), Colors.LemonChiffon);
	}
}
