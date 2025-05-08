using HelperMethods;

namespace AverageOfArray;

public class Program
{
    static void Main(string[] args)
    {
        string lines = Console.ReadLine();
        List<int> averageNumbersResult = new List<int>();

        for (int i = 0; i < int.Parse(lines); i++)
        {
            string line = Console.ReadLine();
            string[] splittedLine = line.Split("\n");
            List<int> parsedInts = Helpers.ParseStringsToInts(splittedLine[i]);
            int average = GetAverageOfArray(parsedInts);
            averageNumbersResult.Add(average);
        }

        Console.WriteLine(string.Join(" ", averageNumbersResult));

    }

    static int GetAverageOfArray(List<int> numbers)
    {
        int sum = 0;
        int average = sum / numbers.Count;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers[i] == 0)
            {
                break;
            }
            if (numbers[i] == 1)
            {
                return 1;
            }
        }

        return average;
    }
}