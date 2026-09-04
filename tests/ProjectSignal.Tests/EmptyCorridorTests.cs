using System.Text.Json;
using ProjectSignal.Core;
using ProjectSignal.Simulation;

namespace ProjectSignal.Tests;

public sealed class EmptyCorridorTests
{
    [Fact]
    public void Run_ProducesCausallyDifferentFactionRecords()
    {
        var run = RunScenario();

        var firstTurn = run.Turns[0];
        Assert.Single(firstTurn.VanguardReports);
        Assert.Equal(3, firstTurn.PlastaiReports.Count);
        Assert.Contains(firstTurn.VanguardReports, report =>
            report.Description.Contains("animal activity", StringComparison.Ordinal));
        Assert.DoesNotContain(firstTurn.VanguardReports, report =>
            report.Description.Contains("nursery", StringComparison.OrdinalIgnoreCase));
        Assert.Contains(firstTurn.PlastaiReports, report =>
            report.Description.Contains("Nursery root chemistry", StringComparison.Ordinal));
    }

    [Fact]
    public void Run_UsesReportsToDriveTurnThreeCommitments()
    {
        var run = RunScenario();
        var thirdTurn = run.Turns[2];

        Assert.Contains(thirdTurn.Orders, order =>
            order.Faction == Faction.Vanguard && order.Kind == "RerouteConvoy");
        Assert.Contains(thirdTurn.Orders, order =>
            order.Faction == Faction.Plastai && order.Kind == "ExtendTrailNetwork");
        Assert.Contains(thirdTurn.Snapshot.ObjectiveFacts, fact =>
            fact == "Vanguard convoy rerouted west: True");
        Assert.Contains(thirdTurn.Snapshot.ObjectiveFacts, fact =>
            fact == "Plastai network observed alternate route: True");
    }

    [Fact]
    public void FactionFacingRecords_DoNotExposeObjectiveTraceIdentifiers()
    {
        var forbiddenNames = new[] { "SourceEventId", "ObjectiveEventId", "SignatureId" };

        var observationProperties = typeof(Observation).GetProperties().Select(property => property.Name);
        var reportProperties = typeof(FactionReport).GetProperties().Select(property => property.Name);

        Assert.Empty(observationProperties.Intersect(forbiddenNames, StringComparer.Ordinal));
        Assert.Empty(reportProperties.Intersect(forbiddenNames, StringComparer.Ordinal));
    }

    [Fact]
    public void FactionReports_DoNotContainAutomatedRatingsOrRecommendations()
    {
        var forbiddenTerms = new[]
        {
            "confidence", "probability", "threat rating", "importance", "reliability", "recommend"
        };
        var reports = RunScenario().Turns
            .SelectMany(turn => turn.VanguardReports.Concat(turn.PlastaiReports));

        foreach (var report in reports)
        {
            Assert.DoesNotContain(forbiddenTerms, term =>
                report.Description.Contains(term, StringComparison.OrdinalIgnoreCase));
        }
    }

    [Fact]
    public void SameSeedAndInputs_ProduceEquivalentRunRecords()
    {
        var first = JsonSerializer.Serialize(RunScenario());
        var second = JsonSerializer.Serialize(RunScenario());

        Assert.Equal(first, second);
    }

    [Fact]
    public void ArtifactWriter_WritesTechnicalLogsAndReadableAar()
    {
        var outputRoot = Path.Combine(Path.GetTempPath(), $"project-signal-{Guid.NewGuid():N}");

        try
        {
            var staleRunDirectory = Path.Combine(outputRoot, "empty-corridor");
            Directory.CreateDirectory(staleRunDirectory);
            File.WriteAllText(Path.Combine(staleRunDirectory, "human-reports.jsonl"), "stale schema v1 artifact");
            File.WriteAllText(Path.Combine(staleRunDirectory, "alien-reports.jsonl"), "stale schema v1 artifact");

            var runDirectory = new RunArtifactWriter().Write(RunScenario(), outputRoot);
            var expectedFiles = new[]
            {
                "manifest.json",
                "orders.jsonl",
                "objective-events.jsonl",
                "signatures.jsonl",
                "vanguard-reports.jsonl",
                "plastai-reports.jsonl",
                "snapshots.jsonl",
                "aar.md"
            };

            Assert.All(expectedFiles, file => Assert.True(File.Exists(Path.Combine(runDirectory, file)), file));
            Assert.False(File.Exists(Path.Combine(runDirectory, "human-reports.jsonl")));
            Assert.False(File.Exists(Path.Combine(runDirectory, "alien-reports.jsonl")));

            var aar = File.ReadAllText(Path.Combine(runDirectory, "aar.md"));
            Assert.Contains("Three-Perspective Timeline", aar, StringComparison.Ordinal);
            Assert.Contains("The Vanguard observed ecological silence", aar, StringComparison.Ordinal);
            Assert.Contains("RerouteConvoy", aar, StringComparison.Ordinal);
            Assert.Contains("| Vanguard |", aar, StringComparison.Ordinal);
            Assert.Contains("| Plastai |", aar, StringComparison.Ordinal);
            Assert.DoesNotContain("| Human |", aar, StringComparison.Ordinal);
            Assert.DoesNotContain("| Alien |", aar, StringComparison.Ordinal);

            var signatureJson = File.ReadLines(Path.Combine(runDirectory, "signatures.jsonl")).First();
            var vanguardReportJson = File.ReadLines(Path.Combine(runDirectory, "vanguard-reports.jsonl")).First();
            var plastaiReportJson = File.ReadLines(Path.Combine(runDirectory, "plastai-reports.jsonl")).First();
            Assert.Contains("sourceEventId", signatureJson, StringComparison.Ordinal);
            Assert.DoesNotContain("sourceEventId", vanguardReportJson, StringComparison.Ordinal);
            Assert.Contains("\"faction\":\"Vanguard\"", vanguardReportJson, StringComparison.Ordinal);
            Assert.Contains("\"faction\":\"Plastai\"", plastaiReportJson, StringComparison.Ordinal);

            var manifestJson = File.ReadAllText(Path.Combine(runDirectory, "manifest.json"));
            Assert.Contains("\"schemaVersion\":2", manifestJson, StringComparison.Ordinal);
        }
        finally
        {
            if (Directory.Exists(outputRoot))
            {
                Directory.Delete(outputRoot, recursive: true);
            }
        }
    }

    private static SimulationRun RunScenario() =>
        new SimulationEngine().Run(new EmptyCorridorScenario(), seed: 39017);
}