namespace GuessNumber.Interfaces;

public interface IGameSettings
{
    int MinNumber { get; set; }
    int MaxNumber { get; set; }
    int MaxAttempts { get; set; }
}