namespace FizzBuzz;

public class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var inputSplit = input.Split(" ");
        int x = int.Parse(inputSplit[0]);
        int y = int.Parse(inputSplit[1]);
        int n = int.Parse(inputSplit[2]);
       string fbList = FizzBuzzResult(x, y, n);
       Console.WriteLine(fbList);
    }

    public static string FizzBuzzResult(int x, int y, int n)
    {
        List<string> result = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            if (i % x == 0 && i % y == 0)
            {
                result.Add("FizzBuzz");
            }
            else if (i % y == 0)
            {
                result.Add("Buzz");
            }
            else if (i % x == 0)
            {
                result.Add("Fizz");
            }
            else
            {
                result.Add(i.ToString());
            }
        }

        return String.Join("\n", result.ToArray());
    }
}