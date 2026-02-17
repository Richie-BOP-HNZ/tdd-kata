namespace TddKata1;

// See https://aka.ms/new-console-template for more information
internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, TDD Kata 1 in C#!!");

        int result = StringCalculator.Add("0");

        Console.WriteLine($"Add: {result}");
        Console.ReadKey();
    }
}

public static class StringCalculator
{
    public static int Add(string numbers)
    {
        // test if numbers is empty, return 0
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        // test if numbers contains a single number (no comma), return that number
        if (!numbers.Contains(','))
        {
            if(int.TryParse(numbers, out int singleNumber))
            {
                return singleNumber;
            }

            return 0;
        }

        var splitNumbers = numbers.Split(',');

        // error check: split has no numbers, return 0 - no point looping through an empty array
        if (splitNumbers.Length == 0)
        {
            return 0;
        }

        int result = 0;

        // loop thru the array and if its a number add to the result
        foreach (var number in splitNumbers)
        {
            if (int.TryParse(number, out int singleNumber))
            {
                result += singleNumber;
            }
        }

        // return result
        return result;
    }
}