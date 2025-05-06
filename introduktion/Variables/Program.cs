namespace Variables;

class Program
{
    static void Main(string[] args)
    {
        /*
        int x;
        int y;

        x = 7;
        y = x + 3;
        
        Console.WriteLine(y);
        */
        
        Console.WriteLine("What is your name?");
        Console.Write("Type your name: ");
        string firstName;
        firstName = Console.ReadLine();

        /*
        string lastName;
        Console.Write("Type your last name: ");
        lastName = Console.ReadLine();*/
        
        Console.WriteLine("Type your last name: ");
        string lastName = Console.ReadLine();
        
        Console.WriteLine("Hello, " + firstName + " " + lastName);
        Console.ReadLine();
    }
}