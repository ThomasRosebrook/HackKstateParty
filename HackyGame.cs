using Godot;
using System;

public partial class HackyGame : Node2D
{
    [Export]
    public PackedScene CodesteroidScene { get; set; }

    private int _score;
    public Vector2 ScreenSize;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
        ScreenSize = GetViewportRect().Size;
        NewGame();
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
        GetNode<Timer>("ScoreTimer").Stop();
    }

	public void NewGame()
	{
		_score = 0;
		var player = GetNode<Player>("Player");
		player.Start(new Vector2(576, 300));
        AudioStreamPlayer bgMusic = GetNode<AudioStreamPlayer>("BGMusic");
        bgMusic.Play();
        GetNode<Timer>("StartTimer").Start();
    }

    private void OnScoreTimerTimeout()
    {
        _score++;
    }

    private void OnStartTimerTimeout()
    {
        GetNode<Timer>("CodesteroidTimer").Start();
        GetNode<Timer>("ScoreTimer").Start();
    }

    private void OnCodesteroidTimerTimeout()
    {
        GD.Print("LOOK MA I MADE IT");
        Codesteroid codesteroid = CodesteroidScene.Instantiate<Codesteroid>();

        codesteroid.Position = new Vector2((float)GD.RandRange(0, ScreenSize.X), 0);

        //codesteroid.LinearVelocity = new Vector2((float)GD.RandRange(-0.5,0.5),(float)GD.RandRange(0.5,1));

        AddChild(codesteroid);
    }
}
