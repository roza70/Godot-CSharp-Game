using Godot;

public partial class MainMenu : Control
{
	public override void _Ready()
	{
		GD.Print("MAIN MENU LOADED");

		Button startButton = GetNodeOrNull<Button>("StartButton");

		if (startButton == null)
		{
			GD.PrintErr("START BUTTON NOT FOUND!");
			return;
		}

		GD.Print("START BUTTON FOUND");

		startButton.Pressed += () =>
		{
			GD.Print("ROZA'S GAME STARTED!");
		};
	}
}
