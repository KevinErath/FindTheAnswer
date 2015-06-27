using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main()
    {
        var numbers = ReadNumbersFromCmd();
        var answer = FindTheAnswer(numbers);
        PrintNumbers(answer);
    }

    public static IEnumerable<int> ReadNumbersFromCmd()
    {
        while (true)
        {
            var line = Console.ReadLine();
            yield return int.Parse(line);
        }
    }

    private static IEnumerable<int> FindTheAnswer(IEnumerable<int> numbers)
    {
        return numbers.TakeWhile(x => x != 42);
    }

    private static void PrintNumbers(IEnumerable<int> numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}