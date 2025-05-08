namespace HelperMethods;

public class Helpers
{
    public static List<int> ParseStringsToInts(string numbers)
    {
        List<int> parsedInts = new List<int>();
        string[] numberToBeParsed = numbers.Split(" ");

        foreach (string s in numberToBeParsed)
        {
             parsedInts.Add(int.Parse(s));
        }

        return parsedInts;
    }
}