using Godot;

public partial class Main : Node
{
	public override void _Ready()
	{
		GD.Print("ProjectSignal Prototype 0 started.");

		var prototypeScenarioRunner = new PrototypeScenarioRunner();
		prototypeScenarioRunner.Run();
	}
}
