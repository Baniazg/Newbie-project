using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Welcome in simple calculator.");


            Console.WriteLine("Please, input a first number. ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, input a second number. ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a action symbol  : [+]Addition , [-] Subtraction, [*] Multiplication, [/] Division ");
            string symbol = Console.ReadLine();
            int result = 0;


            if (symbol == "+")

            {
                result = num1 + num2;
                Console.WriteLine("Result is " + result);


            }
            else if (symbol == "-")
            {
                result = num1 - num2;
                Console.WriteLine("Result is " + result);


            }
            else if (symbol == "*")
            {
                result = num1 * num2;
                Console.WriteLine("Result is " + result);


            }
            else if (symbol == "/")
            {
                result = num1 / num2;
                Console.WriteLine("Result is " + result);



            }
            else
            {
                Console.WriteLine("Havent this calculation yet. Try Again");

            }
            
            Console.ReadLine();

        }
        


    } 

}
