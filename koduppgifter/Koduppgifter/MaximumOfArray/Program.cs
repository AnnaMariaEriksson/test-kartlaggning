namespace MaximumOfArray;

class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string[] inputStrings = input.Split(" ");
        List<int> parsedList = ParseStringsToInts(inputStrings);
        int maximum = FindMaximumOfArray(parsedList);
        int lowest = FindLowestOfArray(parsedList);
        Console.Write(lowest);
    }

    public static List<int> ParseStringsToInts(string[] numbers)
    {
        List<int> parsedInts = new List<int>();
        int numberToBeParsed = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numberToBeParsed = int.Parse(numbers[i]);
            parsedInts.Add(numberToBeParsed);
        }

        return parsedInts;
    }

    public static int FindMaximumOfArray(List<int> numbers)
    {
        int highestCurrentNumber = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] > highestCurrentNumber)
            {
                highestCurrentNumber = numbers[i];
            }
        }

        return highestCurrentNumber;
    }

    public static int FindLowestOfArray(List<int> numbers)
    {
        int lowestCurrentNumber = Int32.MaxValue;

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < lowestCurrentNumber)
            {
                lowestCurrentNumber = numbers[i];
            }
        }

        return lowestCurrentNumber;
    }
}