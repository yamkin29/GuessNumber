using GuessNumber.Interfaces;

namespace GuessNumber;

public class GuessNumberGame
{
    private readonly int _targetNumber;
    private readonly IUserInterface _userInterface;
    private int _attemptsLeft;
    private readonly int _min;
    private readonly int _max;

    public GuessNumberGame(IRandomNumberGenerator randomNumberGenerator, IUserInterface userInterface, IGameSettings settings)
    {
        _targetNumber = randomNumberGenerator.Generate(settings.MinNumber, settings.MaxNumber);
        _userInterface = userInterface;
        _attemptsLeft = settings.MaxAttempts;
        _min = settings.MinNumber;
        _max = settings.MaxNumber;
    }

    public void Start()
    {
        _userInterface.DisplayMessage($"Я загадал число от {_min} до {_max}. Попробуйте угадать.");

        while (_attemptsLeft > 0)
        {
            _userInterface.DisplayMessage($"Осталось попыток: {_attemptsLeft}");
            int guess = _userInterface.GetNumberInput();

            if (guess == _targetNumber)
            {
                _userInterface.DisplayMessage("Поздравляю! Вы угадали число!");
                return;
            }

            _userInterface.DisplayMessage(guess < _targetNumber
                ? "Ваше число меньше загаданного."
                : "Ваше число больше загаданного.");

            _attemptsLeft--;
        }

        _userInterface.DisplayMessage($"Увы, вы не угадали. Загаданное число было: {_targetNumber}");
    }
}