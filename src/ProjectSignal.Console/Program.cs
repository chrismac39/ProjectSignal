using ProjectSignal.Simulation;

var seed = 39017;
var outputRoot = args.Length > 0
	? Path.GetFullPath(args[0])
	: Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "artifacts"));

var run = new SimulationEngine().Run(new EmptyCorridorScenario(), seed);
var runDirectory = new RunArtifactWriter().Write(run, outputRoot);

Console.WriteLine($"Completed '{run.ScenarioTitle}' in {run.Turns.Count} turns.");
Console.WriteLine($"Artifacts: {runDirectory}");
Console.WriteLine($"AAR: {Path.Combine(runDirectory, "aar.md")}");
