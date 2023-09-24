using System.Collections.Immutable;
using Orleans.Runtime;

namespace Connect4Lizard.Grains;

public class PairingGrain : Grain, IPairingGrain
{
	private readonly IPersistentState<GamesInWaiting> _state;
	public PairingGrain([PersistentState("State")] IPersistentState<GamesInWaiting> state)
	{
		_state = state;
	}

	public async Task AddGame(Guid gameId)
    {
		_state.State.GameIds.Add(gameId);
		await _state.WriteStateAsync();
	}

    public async Task RemoveGame(Guid gameId)
    {
		_state.State.GameIds.Remove(gameId);
		await _state.WriteStateAsync();
	}

	public Task<ImmutableArray<Guid>> GetAllGames() =>
		Task.FromResult(ImmutableArray.CreateRange(_state.State.GameIds));
}
