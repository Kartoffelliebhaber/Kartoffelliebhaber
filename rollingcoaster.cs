using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //120 --> go home!
            //12> 5$, 18>=7$, 18< 10$

            int bill;
            int height;
            int age;
            bool in_game = true;


            while (in_game)
            {
                Console.WriteLine("Your height: ");
                String height_input = Console.ReadLine();
                Console.WriteLine("Your age: ");
                String age_input = Console.ReadLine();

                if (int.TryParse(height_input, out height) && int.TryParse(age_input, out age))
                {
                    in_game = false;
                    if (height > 120)
                    {
                        if (age < 12)
                        {
                            bill = 5;
                            Console.WriteLine($"Ticket: {bill}");
                        }
                        else if (age <= 18)
                        {
                            bill = 7;
                            Console.WriteLine($"Ticket: {bill}");
                        }
                        else
                        {
                            bill = 10;
                            Console.WriteLine($"Ticket: {bill}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Go home!");
                    }
                }
                else
                {
                    Console.WriteLine("Give a number!");
                }
            }
        }
    }
}
