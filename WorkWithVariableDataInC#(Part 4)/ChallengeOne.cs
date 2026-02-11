using System;

class ChallengeOne
{
    static void Main(string[] args)
    {
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        decimal total = 0m;
        string message = "";
        int parsedInteger = 0;
        decimal parsedDecimal = 0m;

        foreach (string value in values)
        {
            if (int.TryParse(value, out parsedInteger))
            {
                total += parsedInteger;
            }
            else if (decimal.TryParse(value, out parsedDecimal)){
                total += parsedDecimal;
            }
            else {
                message += value;
            }
        }
        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {total}");
    }
}

