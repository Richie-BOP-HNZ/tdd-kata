namespace TddKata1;

// See https://aka.ms/new-console-template for more information
internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, TDD Kata 1 in C#!!");

        var result = StringCalculator.Add("0");

        Console.WriteLine($"Add: {result.Total}");

        if(!string.IsNullOrEmpty(result.Message))
        {
            Console.WriteLine($"Message: {result.Message}");
        }

        Console.ReadKey();
    }
}

public class CalcResult
{
    public string? Message { get; set; }

    public int Total { get; set; }

    public bool IsSuccess { get; set; } = true;
}

public static class StringCalculator
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input">//[delimiter]\n[numbers...] OR 1;2;3</param>
    /// <returns>returns a List of numbers</returns>
    public static List<int>? GetDelimiterAndNumbers(string input)
    {
        List<int> numbersList = [];

        string delimiter = ";";
        string numbers = "";

        // test if has the header row - //;\n etc
        if (input.StartsWith($"//", StringComparison.InvariantCultureIgnoreCase) && input.Contains($"\n"))
        {
            int position = input.IndexOf('\n');

            if (position > 0)
            {
                delimiter = input.Substring(2, position - 2);
                numbers = input.Substring(position + 1);
            }
        }
        else
        {
            // no header, just process the input as is
            numbers = input;
        }

        // safety check - if either delimiter or numbers is empty then bug out...
        if (string.IsNullOrEmpty(delimiter) || string.IsNullOrEmpty(numbers))
        {
            return null;
        }

        // test if numbers contains a single number (no comma), return that number
        if (!numbers.Contains(delimiter) && int.TryParse(numbers, out int singleNumber))
        {
            numbersList.Add(singleNumber);
        }

        var splitNumbers = numbers.Split(delimiter);

        // loop thru the array and if its a number add to the result
        foreach (var number in splitNumbers)
        {
            if (int.TryParse(number, out int singleNumber2))
            {
                numbersList.Add(singleNumber2);
            }
            else if (number.Contains($"\n"))
            {
                var splitNewLine = number.Split($"\n");

                foreach (var numberNL in splitNewLine)
                {
                    if (int.TryParse(numberNL, out int singleNumberNL))
                    {
                        numbersList.Add(singleNumberNL);                       
                    }
                }
            }
        }

        return numbersList;
    }

    public static CalcResult Add(string input)
    {
        CalcResult result = new();

        // test if input is empty, return 0
        if (string.IsNullOrEmpty(input))
        {
            return result;
        }

        // if input is a number, just return that number...
        if (int.TryParse(input, out int singleNumber))
        {
            result.Total = singleNumber;

            return result;
        }

        var calc = GetDelimiterAndNumbers(input);

        if(calc is null)
        {
            return result;
        }

        foreach (int number in calc)
        {
            if (number < 0)
            {
                result.Message += $"Negative Numbers are not allowed: {number}\n";

                result.IsSuccess = false;
            }
            else
            {
                result.Total += number;
            }
        }

        return result;        
    }
}