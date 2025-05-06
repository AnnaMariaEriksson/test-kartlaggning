namespace Decisions;

class Program
{
    static void Main(string[] args)
    {
        /*
        Console.WriteLine("Bob's Big Giveaway");
        Console.Write("Choose a door: 1, 2 or 3: ");
        string userValue = Console.ReadLine();
        string message = "";

        
        if (userValue == "1")
        {
            message = "You've won a new car!";
            
        }

        else if (userValue == "2")
        {
            message = "You've won a new boat!";
            
        }
        
        else if (userValue == "3")
        {
            message = "You've won a new cat!";
            
        }

        else
        {
            message = "Sorry, we did not understand. ";
            message += "You lose.";

        }
        Console.WriteLine(message);
        Console.ReadLine();
        */
        
        Console.WriteLine("Bob's Big Giveaway");
        Console.Write("Choose a door: 1, 2 or 3: ");
        string userValue = Console.ReadLine();

        string message = (userValue == "1") ? "boat" : "strand of lint";
        
        //Console.WriteLine("You've won a {0}.", message);
        Console.WriteLine("You've entered: {0}, therefore you win a {1}.",userValue, message);
        
        /*
        Console.Write("You've won a ");
        Console.Write(message);
        Console.Write(".");
        Console.ReadLine();*/

    }
}