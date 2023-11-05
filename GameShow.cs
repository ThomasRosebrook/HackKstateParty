using Godot;
using System;
using System.Collections.Generic;

public partial class GameShow : Control
{
	int[] answersNum = new int[4];
	Dictionary<int, string> answers = new Dictionary<int, string>();
	//KeyValuePair<int, string>[] an = new KeyValuePair<int, string>[4]; 
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		answers.Add(0, "Cinnamon Rolls");
		answersNum[0] = 2;
		answersNum[1] = 4;
		answersNum[2] = 3;
		answersNum[3] = 3;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}

	public void Correct(Button button)
	{
		if (answers[0] == button.Text)
		{
			GD.Print("yeh");
			GetTree().ChangeSceneToFile("res://gameshowwaddledoo/CorrectAnswer.tscn");
		}
		else
		{
			GD.Print("Huh");
			GetTree().ChangeSceneToFile("res://gameshowwaddledoo/IncorrectAnswer.tscn");
		}
	}
}
