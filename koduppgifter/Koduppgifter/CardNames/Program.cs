namespace CardNames;

class Program
{
    static void Main(string[] args)
    {
        string[] suits = ["Clubs", "Spades", "Diamonds", "Hearts"];
        string[] ranks =
        [
            "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace"
        ];

        List<string> results = new List<string>();

        string numbers = Console.ReadLine();
        string[] cards = numbers.Split(" ");

        for (int i = 0; i < cards.Length; i++)
        {
            decimal parsed = int.Parse(cards[i]);
            int suitValue = (int)Math.Floor(parsed / 13);
            int rankValue = (int)Math.Floor(parsed % 13);
            string formattedValue = string.Format("{0}-of-{1}", ranks[rankValue], suits[suitValue]);
            results.Add(formattedValue);
        }

        Console.WriteLine(string.Join(" ",results));
    }
}