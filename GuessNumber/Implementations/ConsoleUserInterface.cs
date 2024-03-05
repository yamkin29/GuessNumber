using GuessNumber.Interfaces;

namespace GuessNumber.Implementations;

public class ConsoleUserInterface : IUserInterface
{
    public void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public int GetNumberInput()
    {
        int number;
        
        while (true)
        {
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите корректное число:");
            }
        }
        return number;
    }
}