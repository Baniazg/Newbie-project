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
                    result = Sum(num1, num2);
                }
                else if (symbol == "-")
                {
                    result = Substraction(num1, num2);
                }
                else if (symbol == "*")
                {
                    result = Multiply(num1, num2);
                }
                else if (symbol == "/")
                {
                    result = Divine(num1, num2);
                }
                else
                {
                    Console.WriteLine("Havent this calculation yet. Try Again");
                }

            Console.WriteLine(num1 + symbol + num2 + " = " + result);
            Console.ReadLine();

                
            

        }
        static int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        static int Substraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
        static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }
        static int Divine(int num1, int num2)
        {
            int result = num1 / num2;
            return result;
        }

        



    }

}
