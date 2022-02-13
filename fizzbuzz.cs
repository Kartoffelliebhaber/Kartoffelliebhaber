using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool in_game = true;
            while (in_game) {

                for (int i = 1; i < 100; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);


                        Console.WriteLine("Ismételjem (y/n)?");
                        string repeat_input = Console.ReadLine();
                        if (repeat_input == "n")
                            in_game = false;
                    }
                }
            }
        }
    }
}
