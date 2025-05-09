using HelperMethods;

namespace AverageOfArray;

public class Program
{
    public static void Main(string[] args)
    {
        string lines = Console.ReadLine();
        List<int> averageNumbersResult = new List<int>();

        for (int i = 0; i < int.Parse(lines); i++)
        {
            string line = Console.ReadLine();
            List<int> parsedInts = Helpers.ParseStringsToInts(line);
            decimal average = GetAverageOfArray(parsedInts); //decimals since we will get a non rounded number
            averageNumbersResult.Add((int)Math.Round(average)); // had to round twice to get it to work
        }

        Console.WriteLine(string.Join(" ", averageNumbersResult));

    }

    public static int GetAverageOfArray(List<int> numbers)
    {
        int sum = 0;
        int count = 0; //adding a count that checks for the 0 at the end so it is not included in the average calculation

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == 0)
            {
                break; //if we find a 0, let's stop
            }

            sum += numbers[i];
            count++;
        }

        if (count == 0)
            return 0;

        return (int)Math.Round((decimal)sum / count);
    }

}