// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, TDD Kata World!");

int result = Add("0");

Console.WriteLine($"Add: {result}");

static int Add(string numbers)
{
    if (string.IsNullOrEmpty(numbers))
    {
        return 0;
    }

    return -1;
}
