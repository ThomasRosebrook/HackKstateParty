using Godot;
using System;

public partial class TheFloor : RigidBody2D
{
    [Export]
    public float FloorSpeed { get; set; } = 0.1F;

    const int MAX_RISE = 420 + 69 + 69 + 42 + 20;

    float colY = 0;
    CollisionShape2D collisionBox;
    Sprite2D sprite;

	public override void _Ready()
	{
        Position = new Vector2(576, 948);
        collisionBox = GetNode<CollisionShape2D>("CollisionShape2D");
        sprite = GetNode<Sprite2D>("Sprite2D");
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        if (colY > 0 - MAX_RISE)
        {
            colY = colY - FloorSpeed;
            sprite.Position = new Vector2(0, colY);
            collisionBox.Position = new Vector2(0, colY);
        }
    }
	
}
