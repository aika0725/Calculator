using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {   
        static double readNum ()
        {
            Console.WriteLine("Please give a number");
            double num=0;
            string numString = Console.ReadLine();
            try
            {
                num = double.Parse(numString);

            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Give me another vaild number, i.e., 5");
                numString = Console.ReadLine();
                num = double.Parse(numString);

            }
            return num;
        }

        static double calList ( double a)
        {
            double res = 0;
            double b = readNum();

            Console.WriteLine("Please choose what you are going to do");
            Console.WriteLine("Add a number, please type +");
            Console.WriteLine("Subtract a number, please type -");
            Console.WriteLine("multiply a number, please type *");
            Console.WriteLine("divide a number, please type /");
            

                string option = Console.ReadLine();

                switch (option)
                {
                    case "+":
                        res = a + b;
                        Console.WriteLine(a + option + b + "=" + res);
                        break;
                    case "-":
                        res = a - b;
                        Console.WriteLine(a + option + b + "=" + res);
                        break;
                    case "*":
                        res = a * b;
                        Console.WriteLine(a + option + b + "=" + res);
                        break;
                    case "/":
                        res = a / b;
                        Console.WriteLine(a + option + b + "=" + res);
                        break;
                }

            return res;
        }
        static void Main(string[] args)
        {
            double result = 0;
            result = readNum();
            do
            {
                result = calList(result);
                Console.WriteLine("Press Enter to continue or any key to quit calculating");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);

            Console.WriteLine("===============================");
            Console.WriteLine("Press Esc to quit the program");
            Console.WriteLine("===============================");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            { }
        }
    }
}
