using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Please enter an amount and measurement type you wish to convert.");

                Console.Write("Amount: ");
                double amount = double.Parse(Console.ReadLine());

                Console.Write("Measurement to convert from: ");
                string type = Console.ReadLine();

                if (type == "inches" || type == "inch")
                {
                    amount *= 3.5;
                    if (amount == 1)
                    {
                        Console.WriteLine("That is equivalent to 1 fidget spinner.");
                    }
                    else
                        Console.WriteLine("That is equivalent to " + amount + " fidget spinners.");
                    //Console.WriteLine("test successful");
                }
                else if (type == "fidget spinners" || type == "fidget spinner")
                {
                    amount /= 3.5;
                    if (amount == 1)
                    {
                        Console.WriteLine("That is equivalent to 1 inch.");
                    }
                    else
                        Console.WriteLine("That is equivalent to " + amount + " inches.");
                }
                else if (type == "feet" || type == "foot")
                {
                    amount *= 5;
                    if (amount == 1)
                    {
                        Console.WriteLine("That is equivalent to 1 meme.");
                    }
                    else
                        Console.WriteLine("That is equivalent to " + amount + " memes.");
                }
                else if (type == "meme" || type == "memes")
                {
                    amount /= 5;
                    if (amount == 1)
                    {
                        Console.WriteLine("That is equivalent to 1 foot.");
                    }
                    else
                        Console.WriteLine("That is equivalent to " + amount + " feet.");
                }

                Console.WriteLine("Would you like to perform another conversion? Yes/No or Y/N");
                string decision = Console.ReadLine();

                if (decision == "Yes" || decision == "yes" || decision == "Y" || decision == "y")
                {
                    repeat = true;
                }
                else
                    repeat = false;
            } while (repeat == true);
        }
    }
}
