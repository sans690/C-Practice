using System;

class ChallengeSeven
{
    static void Main(string[] args)
    {
        int numberResult;
        bool validNumber = false;

        Console.WriteLine("Enter an integer between 5 and 10");

        do
        {
            string? readResult = Console.ReadLine();

            validNumber = int.TryParse(readResult, out numberResult);

            if (!validNumber)

            {
                Console.WriteLine($"Sorry, you entered an invalid number, please try again.");
            }

            else if (numberResult < 5 || numberResult > 10)
            {
                validNumber = false;
                Console.WriteLine($"You entered {numberResult}. Please enter a number between 5 and 10.");
            }

            else
            {
                Console.WriteLine($"Your input value ({numberResult}) has been accepted.");
            }

        } while (!validNumber);
    }
}