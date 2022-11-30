using System;

namespace Guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 200);
            string welcome = "Hello, welcome in game. Guess the number betwen 0 and 200";
            int guess = 0;
            Console.WriteLine(welcome);


            while (guess != number)
            {
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < number)
                {
                    Console.WriteLine("Too Low!!!");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too High!!!");
                }


            }
            Console.WriteLine("Great. Correct answer is " + number);
        }
    }
}
