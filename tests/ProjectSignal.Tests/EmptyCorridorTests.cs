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
        Assert.Single(firstTurn.HumanReports);
        Assert.Equal(3, firstTurn.AlienReports.Count);
        Assert.Contains(firstTurn.HumanReports, report =>
            report.Description.Contains("animal activity", StringComparison.Ordinal));
        Assert.DoesNotContain(firstTurn.HumanReports, report =>
            report.Description.Contains("nursery", StringComparison.OrdinalIgnoreCase));
        Assert.Contains(firstTurn.AlienReports, report =>
            report.Description.Contains("Nursery root chemistry", StringComparison.Ordinal));
    }

    [Fact]
    public void Run_UsesReportsToDriveTurnThreeCommitments()
    {
        var run = RunScenario();
        var thirdTurn = run.Turns[2];

        Assert.Contains(thirdTurn.Orders, order =>
            order.Faction == Faction.Human && order.Kind == "RerouteConvoy");
        Assert.Contains(thirdTurn.Orders, order =>
            order.Faction == Faction.Alien && order.Kind == "ExtendTrailNetwork");
        Assert.Contains(thirdTurn.Snapshot.ObjectiveFacts, fact =>
            fact == "Human convoy rerouted west: True");
        Assert.Contains(thirdTurn.Snapshot.ObjectiveFacts, fact =>
            fact == "Alien network observed alternate route: True");
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
            .SelectMany(turn => turn.HumanReports.Concat(turn.AlienReports));

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
            var runDirectory = new RunArtifactWriter().Write(RunScenario(), outputRoot);
            var expectedFiles = new[]
            {
                "manifest.json",
                "orders.jsonl",
                "objective-events.jsonl",
                "signatures.jsonl",
                "human-reports.jsonl",
                "alien-reports.jsonl",
                "snapshots.jsonl",
                "aar.md"
            };

            Assert.All(expectedFiles, file => Assert.True(File.Exists(Path.Combine(runDirectory, file)), file));

            var aar = File.ReadAllText(Path.Combine(runDirectory, "aar.md"));
            Assert.Contains("Three-Perspective Timeline", aar, StringComparison.Ordinal);
            Assert.Contains("Humans observed ecological silence", aar, StringComparison.Ordinal);
            Assert.Contains("RerouteConvoy", aar, StringComparison.Ordinal);

            var signatureJson = File.ReadLines(Path.Combine(runDirectory, "signatures.jsonl")).First();
            var humanReportJson = File.ReadLines(Path.Combine(runDirectory, "human-reports.jsonl")).First();
            Assert.Contains("sourceEventId", signatureJson, StringComparison.Ordinal);
            Assert.DoesNotContain("sourceEventId", humanReportJson, StringComparison.Ordinal);
            Assert.Contains("\"faction\":\"Human\"", humanReportJson, StringComparison.Ordinal);
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