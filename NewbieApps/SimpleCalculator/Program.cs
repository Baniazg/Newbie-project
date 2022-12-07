using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Welcome in simple calculator.");
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Please, input a first number. ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please, input a second number. ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter a action symbol  : [+]Addition , [-] Subtraction, [*] Multiplication, [/] Division ");
                string symbol = Console.ReadLine();
                string tryAgain;
                double result = 0;


                if (symbol == "+")
                {
                    result = Sum(num1, num2);
                }
                else if (symbol == "-")
                {
                    result = Substraction(num1, num2);
                }

                else if (symbol == "/" && num2 == 0)
                {
                    Console.WriteLine("Cant do this");
                    continue;
                }

                else if (symbol == "*")
                {
                    result = Multiply(num1, num2);
                }
                else if (symbol == "/")
                {
                    result = Division(num1, num2);
                }

                else
                {
                    Console.WriteLine("Havent this calculation yet. Try Again");
                }

                Console.WriteLine(num1 + symbol + num2 + " = " + result);
                Console.WriteLine("Wanna another calculation ? [Y][N]");
                tryAgain = Console.ReadLine().ToUpper();
                if (tryAgain == "Y")
                {
                    loop = true;
                }
                else
                {
                    loop = false;
                }
            }
        }
        static double Sum(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        static double Substraction(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        static double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        static double Division(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
