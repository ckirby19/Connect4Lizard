using System.Collections.Immutable;

namespace Connect4Lizard.Grains;

public interface IPlayerGrain : IGrainWithGuidKey
{

    Task<ImmutableArray<Guid>> GetAvailableGames();

    Task<List<GameSummary>> GetGameSummaries();

    // create a new game and join it
    Task<Guid> CreateGame();

    // join an existing game
    Task<GameState> JoinGame(Guid gameId);

    Task LeaveGame(Guid gameId, GameOutcome outcome);

    Task SetUsername(string username);

    Task<string> GetUsername();
}
