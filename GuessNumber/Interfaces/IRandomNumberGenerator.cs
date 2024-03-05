namespace GuessNumber.Interfaces;

public interface IRandomNumberGenerator
{
    int Generate(int min, int max);
}