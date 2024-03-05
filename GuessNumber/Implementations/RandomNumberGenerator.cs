using GuessNumber.Interfaces;

namespace GuessNumber.Implementations;

public class RandomNumberGenerator : IRandomNumberGenerator
{
    private readonly Random _random = new ();

    public int Generate(int min, int max)
    {
        return _random.Next(min, max + 1);
    }
}