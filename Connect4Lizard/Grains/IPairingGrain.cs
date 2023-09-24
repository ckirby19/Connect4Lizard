using System.Collections.Immutable;

namespace Connect4Lizard.Grains;

public interface IPairingGrain : IGrainWithIntegerKey
{
    Task AddGame(Guid gameId);
    Task RemoveGame(Guid gameId);
	Task<ImmutableArray<Guid>> GetAllGames();
}

[Immutable]
[GenerateSerializer]
public class GamesInWaiting
{
    [Id(0)]
    public HashSet<Guid> GameIds { get; set; } = new();
}
