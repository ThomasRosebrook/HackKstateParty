using Godot;
using System;

public partial class HackyGame : Node2D
{
    [Export]
    public PackedScene CodesteroidScene { get; set; }

    [Signal]
    public delegate void FloorRiseEventHandler();
    [Signal]
    public delegate void GameOveredEventHandler();

    private int _score = 0;
    public Vector2 ScreenSize;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
        ScreenSize = GetViewportRect().Size;
        //NewGame();
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
        GetNode<Timer>("CodesteroidTimer").Stop();
        EmitSignal(SignalName.GameOvered);
    }

	public void NewGame()
	{
        GetTree().CallGroup("BadCodeGroup", Node.MethodName.QueueFree);
        
        _score = 0;
        var hud = GetNode<HUD>("HUD");
        hud.UpdateScore(_score);
        var player = GetNode<Player>("Player");
		player.Start(new Vector2(576, 300));
        AudioStreamPlayer bgMusic = GetNode<AudioStreamPlayer>("BGMusic");
        bgMusic.Play();
        GetNode<Timer>("StartTimer").Start();
        EmitSignal(SignalName.FloorRise);
    }

    private void OnStartTimerTimeout()
    {
        GetNode<Timer>("CodesteroidTimer").Start();
    }

    private void OnCodesteroidTimerTimeout()
    {
        GD.Print("LOOK MA I MADE IT");
        Codesteroid codesteroid = CodesteroidScene.Instantiate<Codesteroid>();

        codesteroid.Position = new Vector2((float)GD.RandRange(0, ScreenSize.X), 0);

        var theFloor = GetNode<RigidBody2D>("TheFloor");

        _score++;

        var hud = GetNode<HUD>("HUD");
        hud.UpdateScore(_score);

        AddChild(codesteroid);
    }

    private void OnStartPressed ()
    {
        NewGame();
    }

    private void OnMenuPressed()
    {
        GetTree().ChangeSceneToFile("res://Menu.tscn");
    }
}
