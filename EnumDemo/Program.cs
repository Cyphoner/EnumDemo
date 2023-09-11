using System.Threading.Channels;

namespace EnumDemo
{
    
    enum Beverage
    {
        Coffee,
        Tea,
        Water,
        Soda,
        Juice,
    }
    
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the awesome vending machine");
            Console.WriteLine("Which beverage do you prefer? (Coffee, Tea, Water, Soda, Juice)");
            String userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "coffee":
                    Respond(Beverage.Coffee);
                    break;
                case "tea":
                    Respond(Beverage.Tea);
                    break;
                case "water":
                    Respond(Beverage.Water);
                    break;
                case "soda":
                    Respond(Beverage.Soda);
                    break;
                case "juice":
                    Respond(Beverage.Juice);
                    break;
                default:
                    Console.WriteLine("Invalid input, this drink does not exist");
                    break;


            }
        }
        static void Respond(Beverage drink)
        {
            switch (drink)
            {
                case Beverage.Coffee:
                    Console.WriteLine("You ordered Coffee Latte, very good choice");
                    break;
                case Beverage.Tea:
                    Console.WriteLine("You ordered Tea, jukky");
                    break;
                case Beverage.Water:
                    Console.WriteLine("You ordered water, loool");
                    break;
                case Beverage.Soda:
                    Console.WriteLine("You ordered Pepsi cola, nice man");
                    break;
                case Beverage.Juice:
                    Console.WriteLine("You ordered orange juice, you are very healthy");
                    break;
            }
        }
    }
}