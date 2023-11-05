using Godot;
using System;

public partial class Codesteroid : RigidBody2D
{
	// Called when the node enters the scene tree for the first time.
	string currCodeType = "";
	long codeIndex = 0;

	public override void _Ready()
	{
        var animatedSprite2D = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
		var collisionBox = GetNode<CollisionShape2D>("CollisionShape2D");
        string[] codeTypes = animatedSprite2D.SpriteFrames.GetAnimationNames();
		
		codeIndex = GD.Randi() % codeTypes.Length;
        currCodeType = codeTypes[codeIndex];

        var spriteSize = animatedSprite2D.SpriteFrames.GetFrameTexture(currCodeType, 0).GetSize();

        
		collisionBox.Shape = new RectangleShape2D() { Size = spriteSize };

        animatedSprite2D.Play(currCodeType);
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
