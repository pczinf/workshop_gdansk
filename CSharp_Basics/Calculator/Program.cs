using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class Program
    {
        public static void Main(string[] args)
        {
            /* double x = 14;
             double y = 230;
             double z = 30;
             double result = x * y;
             */
            double result;
            Console.Write("First number=");
            string num1 = Console.ReadLine();
            ////int pnum1 = int.Parse(num1);
            double pnum1 = double.Parse(num1);
            Console.Write("Second number=");
            string num2 = Console.ReadLine();
            ////int pnum2 = int.Parse(num2);
            double pnum2 = double.Parse(num2);
            ////result = pnum1 * pnum2;
            ////Console.WriteLine("x*y="+result);
            ////Console.WriteLine($"x*y={result}");
            /*
            result = Add(pnum1, pnum2);
            Console.WriteLine($"x+y={result}");
            result = Subtr(pnum1, pnum2);
            Console.WriteLine($"x-y={result}");
            result = Mult(pnum1, pnum2);
            Console.WriteLine($"x*y={result}");
            result = Div(pnum1, pnum2);
            Console.WriteLine($"x/y={result}");
            */
            Console.Write("Operation: ");
            string operation = Console.ReadLine();
            if (operation == "+")
            {
                result = Add(pnum1, pnum2);
                Console.WriteLine($"x+y={result}");
            }

            if (operation == "-")
            {
                result = Subtr(pnum1, pnum2);
                Console.WriteLine($"x-y={result}");
            }

            if (operation == "*")
            {
                result = Mult(pnum1, pnum2);
                Console.WriteLine($"x*y={result}");
            }

            if (operation == "/")
            {
                result = Div(pnum1, pnum2);
                Console.WriteLine($"x/y={result}");
            }

            Console.ReadKey();
        }

        public static double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        public static double Subtr(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }

        public static double Mult(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

        public static double Div(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
    }
}
