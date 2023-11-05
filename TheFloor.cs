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

    bool GOGOGO = false;

    public void Reset()
    {
        _Ready();
    }

	public override void _Ready()
	{
        GOGOGO = false;
        Position = new Vector2(576, 948);
        colY = 0;
        collisionBox = GetNode<CollisionShape2D>("CollisionShape2D");
        sprite = GetNode<Sprite2D>("Sprite2D");
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        if (GOGOGO && colY > 0 - MAX_RISE)
        {
            colY = colY - FloorSpeed;
            sprite.Position = new Vector2(0, colY);
            collisionBox.Position = new Vector2(0, colY);
        }
    }

    public void OnFloorRise()
    {
        Reset();
        GOGOGO = true;
    }
	
}