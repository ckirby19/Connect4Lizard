namespace Connect4Lizard.Grains;

/// <summary>
/// Observer interface for an external client, such as a web frontend, to receive updates to the score of a particular game.
/// </summary>
public interface IGameObserver : IGrainObserver
{
	void UpdateGameScore(string score);
}