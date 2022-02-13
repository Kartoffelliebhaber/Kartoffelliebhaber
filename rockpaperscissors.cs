using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            String rock = @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
";

            String paper = @"
    _______
-- - '   ____)____
          ______)
          _______)
         _______)
---.__________)
";

            String scissors = @"
    _______
-- - '   ____)____
          ______)
       __________)
      (____)
-- -.__(___)
";
            string[] tomb = { rock, paper, scissors };
            bool ingame = true;

            while(ingame)
            {
                Console.WriteLine("0-rock,1-paper,2-scissors:");
                string input = Console.ReadLine();
                int choice; 
                
                if(int.TryParse(input, out choice))
                    {
                    if(choice >=0 && choice <= 2)
                    {
                        ingame = false;
                        Random rand = new Random();
                        int random_number = rand.Next(0, 2);
                        Console.WriteLine("Your choice:");
                        Console.WriteLine(choice);
                        Console.WriteLine(tomb[choice]);
                        Console.WriteLine("Computer's choice:");
                        Console.WriteLine(random_number);
                        Console.WriteLine(tomb[random_number]);


                        if ((choice == 0 && random_number == 2) || (choice == 1 && random_number == 0) || (choice == 2 && random_number == 1))
                        {

                            Console.WriteLine("winner!");
                        }
                        else if ((choice == 0 && random_number == 1) || (choice == 1 && random_number == 2) || (choice == 2 && random_number == 0))
                        {
                            Console.WriteLine("Loser!");
                                }
                            else if (choice == random_number)
                               { 
                                Console.WriteLine("Draw"!);
                                 }
                    }
                    else
                    {
                        Console.WriteLine("give a number between 0 and 2!");
                    }
                }
                else
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
