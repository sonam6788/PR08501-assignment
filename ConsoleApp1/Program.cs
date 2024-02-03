// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

class program
{
    static void Main(string[] args)
    {

        // variable declaration

        int health = 6;
        int hunger = 7;
        int happiness = 8;

        //pet selection
        Console.WriteLine("please choose ypur pet type");
        Console.WriteLine("1.cat");
        Console.WriteLine("2.dog");
        Console.WriteLine("3.rabbit\n");

        Console.Write("user input: ");

        //pet name
        int pettype = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nyou have choosen a cat.what would you like to name your pet?");
        Console.Write("user input: ");
        string petname = Console.ReadLine();

        Console.WriteLine($"\ntake care  {petname}");
        while (true)
        {
            // main menu
            Console.WriteLine("\nmain menu");
            Console.WriteLine("1.feed");
            Console.WriteLine("2.play with pet");
            Console.WriteLine("3.let rest");
            Console.WriteLine("4.check");
            Console.WriteLine("5.exit");

            Console.Write("user input: ");
            int petcare = Convert.ToInt32(Console.ReadLine());
            switch (petcare)
            {
                case 1:
                    hunger = hunger - 2; // decrease health
                    health = health + 1; // increase health
                    Console.WriteLine("decrease hunger ,slightly increased health");
                    break;
                case 2:
                    hunger = hunger + 1;//increase hunger
                    happiness = happiness + 1;//increase happiness
                    Console.WriteLine("increase happiness,slightly increases hunger");
                    break;
                case 3:
                    health = health - 2; //decrease health
                    happiness = happiness - 1;//decrease happiness
                    Console.WriteLine("improves health,decrease happiness slightly");
                        break;
                case 4:
                    Console.WriteLine("pet status");
                    Console.WriteLine("hunger : " + Convert.ToString(hunger));
                    Console.WriteLine("health : " + Convert.ToString(health));
                    Console.WriteLine("happiness : " + Convert.ToString(happiness));

                    if (hunger <= 2 || health <= 2 || happiness <= 2)
                    {
                        Console.WriteLine("You pet helth is crictical");
                    }
                    break;
                case 5:
                    Console.WriteLine("Good bye!");
                    return;
                default:
                    Console.WriteLine("invalid option");
                    break;

            }

            // time simulation
            hunger = hunger + 1;
            happiness = happiness - 1;

            if (hunger <= 2 || health <= 2 || happiness <= 2)
            {
                Console.WriteLine("You pet helth is crictical");
            }
        }
    }
}




