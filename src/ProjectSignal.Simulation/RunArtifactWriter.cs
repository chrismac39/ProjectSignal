using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using ProjectSignal.Core;

namespace ProjectSignal.Simulation;

public sealed class RunArtifactWriter
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = false,
        Converters = { new JsonStringEnumConverter() }
    };

    public string Write(SimulationRun run, string outputRoot)
    {
        var runDirectory = Path.Combine(outputRoot, run.ScenarioId);
        Directory.CreateDirectory(runDirectory);

        WriteJson(Path.Combine(runDirectory, "manifest.json"), new
        {
            schemaVersion = 1,
            engine = "ProjectSignal.Headless",
            run.ScenarioId,
            run.ScenarioTitle,
            run.Seed,
            turnCount = run.Turns.Count,
            status = "completed"
        });
        WriteJsonLines(Path.Combine(runDirectory, "orders.jsonl"), run.Turns.SelectMany(turn => turn.Orders));
        WriteJsonLines(Path.Combine(runDirectory, "objective-events.jsonl"), run.Turns.SelectMany(turn => turn.ObjectiveEvents));
        WriteJsonLines(Path.Combine(runDirectory, "signatures.jsonl"), run.Turns.SelectMany(turn => turn.Signatures));
        WriteJsonLines(Path.Combine(runDirectory, "human-reports.jsonl"), run.Turns.SelectMany(turn => turn.HumanReports));
        WriteJsonLines(Path.Combine(runDirectory, "alien-reports.jsonl"), run.Turns.SelectMany(turn => turn.AlienReports));
        WriteJsonLines(Path.Combine(runDirectory, "snapshots.jsonl"), run.Turns.Select(turn => turn.Snapshot));
        File.WriteAllText(Path.Combine(runDirectory, "aar.md"), BuildAar(run), Encoding.UTF8);

        return runDirectory;
    }

    private static void WriteJson<T>(string path, T value) =>
        File.WriteAllText(path, JsonSerializer.Serialize(value, JsonOptions), Encoding.UTF8);

    private static void WriteJsonLines<T>(string path, IEnumerable<T> values)
    {
        var lines = values.Select(value => JsonSerializer.Serialize(value, JsonOptions));
        File.WriteAllLines(path, lines, Encoding.UTF8);
    }

    private static string BuildAar(SimulationRun run)
    {
        var report = new StringBuilder();
        report.AppendLine($"# After-Action Report: {run.ScenarioTitle}");
        report.AppendLine();
        report.AppendLine(run.ScenarioDescription);
        report.AppendLine();
        report.AppendLine($"Seed: `{run.Seed}`");
        report.AppendLine();
        report.AppendLine("## Three-Perspective Timeline");
        report.AppendLine();
        report.AppendLine("| Turn | Objective record | Human record | Alien record |");
        report.AppendLine("| --- | --- | --- | --- |");

        foreach (var turn in run.Turns)
        {
            report.AppendLine(
                $"| {turn.Turn} | {Cell(turn.ObjectiveEvents.Select(item => item.Summary))} " +
                $"| {Cell(turn.HumanReports.Select(item => item.Description))} " +
                $"| {Cell(turn.AlienReports.Select(item => item.Description))} |");
        }

        report.AppendLine();
        report.AppendLine("## Decisions At Commitment");
        report.AppendLine();
        report.AppendLine("| Turn | Faction | Order | Stated intent |");
        report.AppendLine("| --- | --- | --- | --- |");
        foreach (var order in run.Turns.SelectMany(turn => turn.Orders))
        {
            report.AppendLine($"| {order.Turn} | {order.Faction} | {Escape(order.Kind)} at {Escape(order.Destination.Area)} | {Escape(order.Intent)} |");
        }

        report.AppendLine();
        report.AppendLine("## Working Interpretations");
        report.AppendLine();
        foreach (var turn in run.Turns)
        {
            foreach (var interpretation in turn.HumanInterpretations.Concat(turn.AlienInterpretations))
            {
                report.AppendLine($"- Turn {turn.Turn}, {interpretation.Faction}: {interpretation.Claim}");
            }
        }

        report.AppendLine();
        report.AppendLine("## Findings");
        report.AppendLine();
        foreach (var finding in run.AarFindings)
        {
            report.AppendLine($"- {finding}");
        }

        report.AppendLine();
        report.AppendLine("Faction reports above are immutable accounts of collected evidence. Working interpretations are commander claims, not simulation-endorsed facts.");
        return report.ToString();
    }

    private static string Cell(IEnumerable<string> values)
    {
        var escaped = values.Select(Escape).ToArray();
        return escaped.Length == 0 ? "No report delivered." : string.Join("<br>", escaped);
    }

    private static string Escape(string value) => value.Replace("|", "\\|", StringComparison.Ordinal);
}