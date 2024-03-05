using GuessNumber.Implementations;
using GuessNumber.Interfaces;

namespace GuessNumber;

class Program
{
    static void Main(string[] args)
    {
        IRandomNumberGenerator randomNumberGenerator = new RandomNumberGenerator();
        IUserInterface userInterface = new ConsoleUserInterface();
        
        IGameSettings settings = new GameSettings
        {
            MinNumber = 1,
            MaxNumber = 100,
            MaxAttempts = 10
        };

        GuessNumberGame game = new GuessNumberGame(randomNumberGenerator, userInterface, settings);
        game.Start();
    }
}