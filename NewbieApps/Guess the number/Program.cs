using System;

namespace Guess_the_number
{
    class Program
    {
        static void Greetings()
        {
            string welcome = "Hello, welcome in game. Guess the number betwen 0 and 200";

            Console.WriteLine(welcome);
        }
        static void MyGame()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 200);
            int guess = 0;
            bool TryAgain = true;
            string Answer = "";
            int count = 0;

            while (TryAgain)
            {
                while (guess != number)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("That's not a number. Write a number ");
                        continue;
                    }

                    if (guess < number)
                    {
                        Console.WriteLine("Too Low!!!");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Too High!!!");
                    }
                    count += 1;
                }
                Console.WriteLine("Great. Correct answer is " + number + " Number of try is " + count);
                Console.WriteLine("Wanna try again ?[y]es or [n]o ");
                Answer = Console.ReadLine();

                if (Answer == "y")
                {
                    Console.WriteLine("Ok. As you wish. Guess the number betwen 0 and 200");
                    TryAgain = true;
                    int num = rnd.Next(0, 200);
                    number = num;
                }

                else
                {
                    Console.WriteLine(" Thank you for a game. See you later");
                    TryAgain = false;
                }
            }
        }
        static void Main(string[] args)
        {
            Greetings();
            MyGame();
        }
    }
}